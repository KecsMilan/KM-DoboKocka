using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KM_dobokocka
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();

        List<int> jatekos_dobasok = new List<int>();
        List<int> gep_dobasok = new List<int>();

        List<int> jatekos_gy_szeria = new List<int>();
        List<int> gep_gy_szeria = new List<int>();

        int jatekos_gy_ossz = 0;
        int gep_gy_ossz = 0;

        int jatekos_sum_ = 0;
        int gep_sum_ = 0;

        private void indit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++) 
            {
                jatekos_dobasok.Add(rnd.Next(1, 7));
                gep_dobasok.Add(rnd.Next(1, 7));
            }

            jatekos_lista.Text = string.Join($"{" ",10}", jatekos_dobasok);
            gep_lista.Text = string.Join($"{" ",10}", gep_dobasok);

            
            for (int i = 0; i < jatekos_dobasok.Count;i++) 
            {
                if (jatekos_dobasok[i] > gep_dobasok[i])
                {
                    jatekos_gy_szeria.Add(1);
                    jatekos_gy_ossz++;
                }
                else if (jatekos_dobasok[i] < gep_dobasok[i])
                {
                    gep_gy_szeria.Add(1);
                    gep_gy_ossz++;
                }
                else 
                {
                    jatekos_gy_szeria.Add(0);
                    gep_gy_szeria.Add(0);
                }
            }

            int count_jatekos = 0;
            int jatekos_max = 0;

            int count_gep = 0;
            int gep_max = 0;

            for (int i = 0; i < jatekos_gy_szeria.Count; i++) 
            {
                if (jatekos_gy_szeria[i] == 1)
                {
                    count_jatekos++;
                    if (count_jatekos > jatekos_max) 
                    {
                        jatekos_max = count_jatekos;
                    }
                }
                else 
                {
                    count_jatekos = 0;
                }
            }

            for (int i = 0; i < gep_gy_szeria.Count; i++)
            {
                if (gep_gy_szeria[i] == 1)
                {
                    count_gep++;
                    if (count_gep > gep_max)
                    {
                        gep_max = count_gep;
                    }
                }
                else
                {
                    count_gep = 0;
                }
            }



            if (jatekos_max > 3)
            {
                jatekos_szeria.Text = "Volt.";
            }
            else 
            {
                jatekos_szeria.Text = "Nem volt.";
            }

            if (gep_max > 3)
            {
                gep_szeria.Text = "Volt.";
            }
            else 
            {
                gep_szeria.Text = "Nem volt.";
            }

            jatekos_gyozelmei.Text = jatekos_gy_ossz.ToString();
            gep_gyozelmei.Text = gep_gy_ossz.ToString();

            jatekos_6osDobasok.Text = hatosok_j().ToString();
            gep_6osDobasok.Text = hatosok_g().ToString();

            jatekos_sum_ = jatekos_dobasok.Sum();
            gep_sum_ = gep_dobasok.Sum();

            if (jatekos_sum_ > gep_sum_)
            {
                jatekos_sum.ForeColor = Color.Green;
                gep_sum.ForeColor = Color.Red;

                jatekos_sum.Text = jatekos_sum_.ToString();
                gep_sum.Text = gep_sum_.ToString();

            }
            else if (gep_sum_ > jatekos_sum_)
            {
                gep_sum.ForeColor = Color.Green;
                jatekos_sum.ForeColor = Color.Red;

                jatekos_sum.Text = jatekos_sum_.ToString();
                gep_sum.Text = gep_sum_.ToString();

            }
            else 
            {
                gep_sum.ForeColor = Color.Gold;
                jatekos_sum.ForeColor = Color.Gold;

                jatekos_sum.Text = jatekos_sum_.ToString();
                gep_sum.Text = gep_sum_.ToString();
            }

                torol();
        }

        private void idozito_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            jatekos_lista.Text = "";
            gep_lista.Text = "";
            gep_sum.Text = "";
            jatekos_sum.Text = "";
        }

        private void jatekos_gyozelmei_Click(object sender, EventArgs e)
        {
            
        }

        private int hatosok_j() 
        {
            int hatos_j = 0;
            foreach (var item in jatekos_dobasok) 
            {
                if (item == 6) 
                {
                    hatos_j++;
                }
            }
            return hatos_j;
        }
        private int hatosok_g() 
        {
            int hatos_g = 0;
            foreach (var item in gep_dobasok)
            {
                if (item == 6)
                {
                    hatos_g++;
                }
            }
            return hatos_g;
        }

        private void torol() 
        {
            jatekos_dobasok.Clear();
            gep_dobasok.Clear();
            jatekos_gy_szeria.Clear();
            gep_gy_szeria.Clear();
            jatekos_sum_ = 0;
            gep_sum_ = 0;
            jatekos_gy_ossz = 0;
            gep_gy_ossz = 0;
        }
    }
}
