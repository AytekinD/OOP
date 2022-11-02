using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Event
{
    public partial class Form1 : Form
    {
        //Bir Olayin gerceklestigini belirten tetikleyicidir
        //Event tetiklendiginde onceden yazilmis kodlar calisacaktir
        //Govdesiz metoda benzerler. Lakin handle etme surei farklidir
        //Metod ne yapacagini bildigimiz ve ne zaman calisacagini bildigimiz durumlarda calisir
        //Event te en az iki obje vardir. Bir taraf ne yapilacagini bilir ama ne zaman yapilacagini bilmez
        //diger taraf ise ne zaman yapilacagini bilir. Ama ne yapilacagini bilmez.


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TepkiGosteren tepkiGosteren = new TepkiGosteren();
            Bagiran bagiran = new Bagiran();

            bagiran.Bagirdim += tepkiGosteren.TepkiVer;
            bagiran.HerhangiBirIslemYap();
        }
    }
}
