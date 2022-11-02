namespace _11_EventYangin
{
    public class Program
    {
        public delegate void EventTip(object sender);
        static void Main(string[] args)
        {
            //Kablo Yanarsa Alarm Calar.
            //Alarm Calarsa Itfaiye gelir.
            //Alarm Calarsa Komsular Rahatsiz Olur.
            //Alarm Calarsa Insanlar Kacar

            // Kablo
            // Alarm 
            // İtfaiye
            // Komsular
            // Insanlar

            Kablo kablo = new Kablo();
            Alarm alarm = new Alarm();
            Itfaiye itfaiye = new Itfaiye();
            Insanlar cemal = new Insanlar();
            Insanlar Ali = new Insanlar();
            Komsular komsular = new Komsular();

            kablo.Yandim += alarm.AlarmCal;
            alarm.AlarmCaldi += itfaiye.MudahaleEt;
            alarm.AlarmCaldi += Ali.RahatsizOl;
            alarm.AlarmCaldi += Ali.Kac;
            alarm.AlarmCaldi += cemal.RahatsizOl;
            alarm.AlarmCaldi += cemal.Kac;
            alarm.AlarmCaldi += komsular.RahatsizOl;

            kablo.AkimGecir();


            // olaylari Birbirine baglayalim



        }
    }
}