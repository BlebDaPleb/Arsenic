﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ezOverLay;
using swed32;

namespace Arsenic
{
    public partial class Form2 : Form
    {
        
        Pen teamPen = new Pen(Color.Green, 2);
        Pen enemyPen = new Pen(Color.Red, 2);

        swed m = new swed();
        ez ez = new ez();

        Entity player = Form1.player;
        List<Entity> entitiesWH = Form1.entitiesWH;

        public Form2()
        {
            InitializeComponent();
            ez.SetInvi(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ez.DoStuff("Counter-Strike: Global Offensive - Direct3D 9", this);
        }



        public void refreshPanel()
        {
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            if (entitiesWH.Count > 0)
            {
                try
                {
                    foreach (var entity in entitiesWH)
                    {
                        if (entity.team == player.team)
                        {

                            if (Form1.ShowTeamWH)
                            {
                                g.DrawRectangle(teamPen, entity.rect());

                                if (Form1.SnaplineEnabledBool && Form1.TeamSnapLine)
                                {
                                    if (entity.bottom.X <= -99 || entity.bottom.Y <= -99)
                                        continue;

                                    g.DrawLine(teamPen, Width / 2, Height, entity.bottom.X, entity.bottom.Y);
                                }
                            }

                        }
                        else if (entity.team != player.team && entity.team > 1)
                        {

                            if (Form1.ShowEnemyWH)
                            {
                                g.DrawRectangle(enemyPen, entity.rect());

                                if (Form1.SnaplineEnabledBool && Form1.EnemySnapline)
                                {
                                    if (entity.bottom.X <= -99 || entity.bottom.Y <= -99)
                                        continue;
                                    g.DrawLine(enemyPen, Width / 2, Height, entity.bottom.X, entity.bottom.Y);
                                }
                            }
                        }

                    }

                }
                catch { }
            }
        }
        
    }
}
