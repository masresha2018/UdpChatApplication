using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageEncodeDecode
{
    public partial class Form1 : Form
    {
        string unicodeString = "This string contains the unicode character Pi (\u03a0)";
        Encoding ascii = Encoding.ASCII;
        Encoding unicode = Encoding.Unicode;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Second COnsole");
            Console.WriteLine("hello");
            // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);


            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            // Display the strings created before and after the conversion.
            txtEncodingMessage.Text = unicodeString;
            txtDecodingmessage.Text = asciiString;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
