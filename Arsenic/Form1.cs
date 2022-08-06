using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using swed32;

namespace Arsenic
{
    public partial class Form1 : Form
    {
        
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        // Menu stuff
        static bool menuVisible = true;

        static swed m = new swed();
        static string processName = "csgo";

        #region Keys

        Keys triggerbotKey = Keys.XButton1;
        Keys aimbotKey = Keys.XButton2;

        #endregion

        #region Offsets

        // CLIENT
        public const int LOCALPLAYER = 0xDBF4BC;
        public const int ENTITYLIST = 0x4DDB8FC;

        // ENGINE
        public const int CLIENTSTATE = 0x58CFDC;
        public const int VIEWANGLES = 0x4D90;

        // OFFSETS
        public const int HEALTH = 0x100;
        public const int TEAM = 0xF4;
        public const int XYZ = 0x138;
        public const int FORCEATTACK = 0x320BDC8;
        public const int CROSSHAIRID = 0x11838;
        public const int LIFESTATE = 0x25F;
        public const int DORMANT = 0xED;
        public const int VIEWMATRIX = 0x4DCD214;

        #endregion

        public static Entity player = new Entity();
        public List<Entity> entitiesAB = new List<Entity>();
        public static List<Entity> entitiesWH = new List<Entity>();

        public static bool ShowEnemyWH;
        public static bool ShowTeamWH;
        public static bool SnaplineEnabledBool;
        public static bool EnemySnapline;
        public static bool TeamSnapLine;

        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            // Removes the borders
            this.FormBorderStyle = FormBorderStyle.None;

            // Makes form start on top left corner
            this.StartPosition = FormStartPosition.Manual;

            // Makes form topmost
            this.TopMost = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            CheckForIllegalCrossThreadCalls = false;

            Thread shm = new Thread(ShowHideMenu);

            Thread tb = new Thread(doTriggerbot) { IsBackground = true };
            Thread ab = new Thread(doAimbot) { IsBackground = true };
            Thread wh = new Thread(doESP) { IsBackground = true };

            m.GetProcess(processName);
            
            shm.Start();

            tb.Start();
            ab.Start();
            wh.Start();

            // Makes form 2 hidden at first
            f2.Hide();

        }

        void doAimbot()
        {
            while (true)
            {
                if (AimbotEnabled.Checked)
                {
                    if(GetAsyncKeyState(aimbotKey) < 0)
                    {

                        updateLocal();
                        updateEntitiesAB();

                        entitiesAB = entitiesAB.OrderBy(o => o.magnitude).ToList();

                        Aim(entitiesAB[0]);

                    }
                }

                Thread.Sleep(1);

            }
        }

        void doTriggerbot()
        {
            while (true)
            {
                if (TriggerbotEnabled.Checked)
                {
                    if (GetAsyncKeyState(triggerbotKey) < 0)
                    {

                        var buffer = m.ReadPointer(m.GetModuleBase("client.dll"), LOCALPLAYER);
                        var cross = BitConverter.ToInt32(m.ReadBytes(buffer, CROSSHAIRID, 4), 0);
                        var myTeam = BitConverter.ToInt32(m.ReadBytes(buffer, TEAM, 4), 0);

                        var target = m.ReadPointer(m.GetModuleBase("client.dll"), ENTITYLIST
                            + (cross - 1) * 0x10);

                        var targetTeam = BitConverter.ToInt32(m.ReadBytes(target, TEAM, 4), 0);
                        var targetLifestate = BitConverter.ToInt32(m.ReadBytes(target, LIFESTATE, 4), 0);
                        
                        if (myTeam != targetTeam && targetTeam > 1 && targetLifestate == 0)
                        {
                            m.WriteBytes(m.GetModuleBase("client.dll"), FORCEATTACK, BitConverter.GetBytes(5));
                            Thread.Sleep(1);
                            m.WriteBytes(m.GetModuleBase("client.dll"), FORCEATTACK, BitConverter.GetBytes(4));
                        }
                                                /*
                         * If Burst/Spray is enabled
                        if (myTeam != targetTeam && targetTeam > 1 && targetLifestate == 0 
                            && target.ToInt32() > 346438400)
                        {
                            m.WriteBytes(m.GetModuleBase("client.dll"), FORCEATTACK, BitConverter.GetBytes(5));
                            Thread.Sleep(1);
                        } else
                        {
                            m.WriteBytes(m.GetModuleBase("client.dll"), FORCEATTACK, BitConverter.GetBytes(4));
                        }
                        */
                        
                    }
                }

                Thread.Sleep(1);

            }
        }

        void Aim(Entity ent)
        {

            if (ent.team > 1)
            {
                // X

                float deltaX = (ent.x) - player.x;
                float deltaY = ent.y - player.y;

                float X = (float)(Math.Atan2(deltaY, deltaX) * 180 / Math.PI);

                // Y

                float deltaZ = ent.z - player.z;
                double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

                float Y = -(float)(Math.Atan2(deltaZ, dist) * 180 / Math.PI);

                // Writing

                var buffer = m.ReadPointer(m.GetModuleBase("engine.dll"), CLIENTSTATE);

                m.WriteBytes(buffer, VIEWANGLES, BitConverter.GetBytes(Y));
                m.WriteBytes(buffer, VIEWANGLES + 0x4, BitConverter.GetBytes(X));
            }

        }

        
        void doESP()
        {
            while (true)
            {
                if (WHEnabled.Checked)
                {
                    updateLocal();
                    updateEntitiesWH();
                    f2.refreshPanel();
                }

                Thread.Sleep(10);
            }

        }
        
        float calcDist(Entity ent)
        {

            var xx = (f2.whPanel.Width / 2);
            var xy = (f2.whPanel.Height / 2);

            // WATCH VIDEO TO GET CORRECT EQUATION
            return (float) Math.Abs(Math.Sqrt(Math.Pow(xx - ent.top.X, 2)));

        }

        float calcMag(Entity e)
        {
            return (float) Math.Sqrt(Math.Pow(e.x - player.x, 2) + Math.Pow(e.y - player.y, 2)
                + Math.Pow(e.z - player.z, 2));
        }

        void updateLocal()
        {

            var buffer = m.ReadPointer(m.GetModuleBase("client.dll"), LOCALPLAYER);
            var coords = m.ReadBytes(buffer, XYZ, 12);

            player.x = BitConverter.ToSingle(coords, 0);
            player.y = BitConverter.ToSingle(coords, 4);
            player.z = BitConverter.ToSingle(coords, 8);

            player.team = BitConverter.ToInt32(m.ReadBytes(buffer, TEAM, 4), 0);

        }

        void updateEntitiesAB()
        {
            entitiesAB.Clear();

            for(int i = 1; i < 64; i++)
            {

                var buffer = m.ReadPointer(m.GetModuleBase("client.dll"), ENTITYLIST + i * 0x10);
                var tm = BitConverter.ToInt32(m.ReadBytes(buffer, TEAM, 4), 0);
                var dorm = BitConverter.ToInt32(m.ReadBytes(buffer, DORMANT, 4), 0);
                var ls = BitConverter.ToInt32(m.ReadBytes(buffer, LIFESTATE, 4), 0);                
                var hp = BitConverter.ToInt32(m.ReadBytes(buffer, HEALTH, 4), 0);

                if (ls != 0 || dorm != 0 || tm == player.team)
                    continue;

                var coords = m.ReadBytes(buffer, XYZ, 12);

                Entity ent = new Entity();

                ent.x = BitConverter.ToSingle(coords, 0);
                ent.y = BitConverter.ToSingle(coords, 4);
                ent.z = BitConverter.ToSingle(coords, 8);
                ent.team = tm;
                ent.lifestate = ls;
                ent.health = hp;

                ent.magnitude = calcMag(ent);

                entitiesAB.Add(ent);

            }
        }

        void updateEntitiesWH()
        {
            entitiesWH.Clear();

            for (int i = 1; i < 64; i++)
            {

                var buffer = m.ReadPointer(m.GetModuleBase("client.dll"), ENTITYLIST + i * 0x10);
                var tm = BitConverter.ToInt32(m.ReadBytes(buffer, TEAM, 4), 0);
                var dorm = BitConverter.ToInt32(m.ReadBytes(buffer, DORMANT, 4), 0);
                var ls = BitConverter.ToInt32(m.ReadBytes(buffer, LIFESTATE, 4), 0); var hp = BitConverter.ToInt32(m.ReadBytes(buffer, HEALTH, 4), 0);

                if (ls != 0 || dorm != 0)
                    continue;

                var coords = m.ReadBytes(buffer, XYZ, 12);

                Entity ent = new Entity();

                ent.x = BitConverter.ToSingle(coords, 0);
                ent.y = BitConverter.ToSingle(coords, 4);
                ent.z = BitConverter.ToSingle(coords, 8);
                ent.team = tm;
                ent.lifestate = ls;
                ent.health = hp;

                ent.magnitude = calcMag(ent);

                ent.bottom = WorldToScreen(readMatrix(), ent.x, ent.y, ent.z - 15, f2.Width, f2.Height);
                ent.top = WorldToScreen(readMatrix(), ent.x, ent.y, ent.z + 58, f2.Width, f2.Height);

                entitiesWH.Add(ent);

            }
        }

        Point WorldToScreen(Viewmatrix mtx, float x, float y, float z, int width, int height)
        {

            var twoD = new Point();

            float screenW = (mtx.m41 * x) + (mtx.m42 * y) + (mtx.m43 * z) + mtx.m44;

            if (screenW > 0.001f)
            {

                float screenX = (mtx.m11 * x) + (mtx.m12 * y) + (mtx.m13 * z) + mtx.m14;
                float screenY = (mtx.m21 * x) + (mtx.m22 * y) + (mtx.m23 * z) + mtx.m24;

                float camX = width / 2f;
                float camY = height / 2f;

                float X = camX + (camX * screenX / screenW);
                float Y = camY - (camY * screenY / screenW);

                twoD.X = (int)X;
                twoD.Y = (int)Y;

                return twoD;

            }
            else
            {
                return new Point(-99, -99);
            }
        }

        Viewmatrix readMatrix()
        {

            var matrix = new Viewmatrix();

            var buffer = new byte[16 * 4];

            buffer = m.ReadBytes(m.GetModuleBase("client.dll"), VIEWMATRIX, buffer.Length);

            matrix.m11 = BitConverter.ToSingle(buffer, 0 * 4);
            matrix.m12 = BitConverter.ToSingle(buffer, 1 * 4);
            matrix.m13 = BitConverter.ToSingle(buffer, 2 * 4);
            matrix.m14 = BitConverter.ToSingle(buffer, 3 * 4);

            matrix.m21 = BitConverter.ToSingle(buffer, 4 * 4);
            matrix.m22 = BitConverter.ToSingle(buffer, 5 * 4);
            matrix.m23 = BitConverter.ToSingle(buffer, 6 * 4);
            matrix.m24 = BitConverter.ToSingle(buffer, 7 * 4);

            matrix.m31 = BitConverter.ToSingle(buffer, 8 * 4);
            matrix.m32 = BitConverter.ToSingle(buffer, 9 * 4);
            matrix.m33 = BitConverter.ToSingle(buffer, 10 * 4);
            matrix.m34 = BitConverter.ToSingle(buffer, 11 * 4);

            matrix.m41 = BitConverter.ToSingle(buffer, 12 * 4);
            matrix.m42 = BitConverter.ToSingle(buffer, 13 * 4);
            matrix.m43 = BitConverter.ToSingle(buffer, 14 * 4);
            matrix.m44 = BitConverter.ToSingle(buffer, 15 * 4);

            return matrix;

        }

        void ShowHideMenu()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.Insert) < 0)
                {
                    if (menuVisible)
                    {
                        this.Hide();
                        menuVisible = false;
                        Thread.Sleep(15);
                    }
                    else
                    {
                        this.Show();
                        menuVisible = true;
                        Thread.Sleep(15);
                    }
                }
                else if (GetAsyncKeyState(Keys.Delete) < 0)
                {
                    Environment.Exit(0);
                    Application.Exit();
                }

                Thread.Sleep(70);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // End all created threads and shut down the process
            Environment.Exit(0);
            Application.Exit();
        }

        #region WH UI

        private void WHEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (WHEnabled.Checked)
                f2.Show();
            else
                f2.Hide();
        }

        private void ShowEnemy_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowEnemy.Checked)
                ShowEnemyWH = true;
            else
                ShowEnemyWH = false;
        }

        private void ShowTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowTeam.Checked)
                ShowTeamWH = true;
            else
                ShowTeamWH = false;
        }

        private void SnaplineEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (SnaplineEnabled.Checked)
                SnaplineEnabledBool = true;
            else
                SnaplineEnabledBool = false;
        }

        private void ShowEnemySnap_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowEnemySnap.Checked)
                EnemySnapline = true;
            else
                EnemySnapline = false;
        }

        private void ShowTeamSnapline_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowTeamSnapline.Checked)
                TeamSnapLine = true;
            else
                TeamSnapLine = false;
        }

        #endregion

    }
}
