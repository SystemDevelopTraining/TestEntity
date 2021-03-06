﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        static void InsertHoges(string asdf)
        {
            //usingを使用しているのでブロックを抜けた時に
            //BooksDbContextオブジェクトは破棄される
            using (var db = new TestEntity.Models.HogeDbContext())
            {
                //データ生成
                var hoge1 = new TestEntity.Models.Hoge
                {
                    //IDは自動生成の為、登録しない
                    Name = asdf
                };
                //book1の追加
                db.Hoges.Add(hoge1);
                //DBの更新
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertHoges(textBox1.Text);
        }
    }
}
