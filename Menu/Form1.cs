using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.Items.Add("Başlangıç");
            cmbMenu.Items.Add("Ara Sıcaklar");
            cmbMenu.Items.Add("Ana Yemekler");
            cmbMenu.Items.Add("Tatlılar");
            cmbMenu.Items.Add("İçecekler");
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstYemekler.Items.Clear();
            switch(cmbMenu.Text)
            {
                case "Başlancıç":
                    {
                        lstYemekler.Items.Add("Çorba");
                        lstYemekler.Items.Add("Patates Kızartması");
                        lstYemekler.Items.Add("Salata");
                        lstYemekler.Items.Add("Çiğ Köfte");
                        break;
                    }
                case "Ara Sıcaklar":
                    {
                        lstYemekler.Items.Add("Fındık Lahmacun");
                        lstYemekler.Items.Add("İçli Köfte");
                        break;
                    }
                case "Ana Yemekler":
                    {
                        lstYemekler.Items.Add("İskender");
                        lstYemekler.Items.Add("Lahmacun");
                        lstYemekler.Items.Add("Döner");
                        break;
                    }
                case "Tatlılar":
                    {
                        lstYemekler.Items.Add("Tavuk Göğsü");
                        lstYemekler.Items.Add("Baklava");
                        lstYemekler.Items.Add("Kazandibi");
                        lstYemekler.Items.Add("Tulumba");
                        lstYemekler.Items.Add("Ekler");
                        lstYemekler.Items.Add("Pasta");
                        break;
                    }
                case "İçecekler":
                    {
                        lstYemekler.Items.Add("Ayran");
                        lstYemekler.Items.Add("Kola");
                        lstYemekler.Items.Add("Su");
                        break;
                    }
            }
        }
    }
}
