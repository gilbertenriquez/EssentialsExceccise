using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssentialsExceccise
{
    public partial class MainPage : ContentPage
    {
        private int num = 0;
        private string[] words = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };
        public MainPage()
        {
            InitializeComponent();
            AdviceWord.Text = words[num];
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            num++;
            if (num >= words.Length)
                num = 0;

            AdviceWord.Text = words[num];
        }
    }
}