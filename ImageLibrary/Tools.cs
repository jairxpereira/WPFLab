
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace ImageLibrary
{
    public class Tools
    {
        public static void sayHello( string msg)
        {

            if ( msg ==null || msg == "")
            MessageBox.Show("Sucess! This is a hello from a lib", "Lib: ImageLibrary.dll");
            else
                MessageBox.Show( 
                    msg, "Lib: ImageLibrary.dll");

        }
    }
}
