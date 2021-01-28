using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        public static int[] dizi = { 25, 89, 117, 342, 378, 413, 560, 621, 781, 795, 823 };
        public int ilk = 0;
        public int son = dizi.Length - 1;
        public int orta;
        public Form1()
        {
            InitializeComponent();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            orta = (ilk + son) / 2;
        }

        private void txt_sayi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dizi[orta] != Convert.ToInt32(txt_sayi.Text))
                {

                    ok.Visible = true;
                    if (ilk <= son)
                    {
                        orta = (ilk + son) / 2;
                        if (orta == 0)
                            ok.Location = new Point(170, btn_sayi1.Location.Y);
                        if (orta == 1)
                            ok.Location = new Point(170, btn_sayi2.Location.Y);
                        if (orta == 2)
                            ok.Location = new Point(170, btn_sayi3.Location.Y);
                        if (orta == 3)
                            ok.Location = new Point(170, btn_sayi4.Location.Y);
                        if (orta == 4)
                            ok.Location = new Point(170, btn_sayi5.Location.Y);
                        if (orta == 5)
                            ok.Location = new Point(170, btn_sayi6.Location.Y);
                        if (orta == 6)
                            ok.Location = new Point(170, btn_sayi7.Location.Y);
                        if (orta == 7)
                            ok.Location = new Point(170, btn_sayi8.Location.Y);
                        if (orta == 8)
                            ok.Location = new Point(170, btn_sayi9.Location.Y);
                        if (orta == 9)
                            ok.Location = new Point(170, btn_sayi10.Location.Y);
                        if (orta == 10)
                            ok.Location = new Point(170, btn_sayi11.Location.Y);

                        if (dizi[orta] == Convert.ToInt32(txt_sayi.Text))
                        {

                            lbl_sonuc.Visible = true;
                            lbl_sonuc.Text = "Sayı " + (orta + 1) + ". kutuda bulundu";
                            ilk = 0;
                            son = dizi.Length - 1;
                            button1.Visible = true;
                        }
                        else if (dizi[orta] < Convert.ToInt32(txt_sayi.Text))
                            ilk = orta + 1;
                        else
                            son = orta - 1;
                    }
                    else
                    {
                        lbl_sonuc.Visible = true;
                        lbl_sonuc.Text = "Sayı bulunamadı.";
                        button1.Visible = true;
           
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //tekrar butonu
        {
            ilk = 0;
            son = dizi.Length - 1;
            lbl_sonuc.Visible = false;
            txt_sayi.Text = "";
            txt_sayi.Focus();
            ok.Visible = false;
        }
    }
}
