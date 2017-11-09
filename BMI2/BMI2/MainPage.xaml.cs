using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI2

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Double h = Double.Parse(Height.Text);
            Double w = Double.Parse(Weight.Text);

            String B = "";

            //DisplayAlert("身長", h.ToString(), "OK");
            //DisplayAlert("体重", w.ToString(), "OK");

            if (h >= 3)
            {
                h = h / 100;
            }

            Double BMI = w / (h * h);

            if (BMI >= 30)
            {
                B = "肥満";
            }
            else if (BMI >= 18.5)
            {
                B = "普通体重";
            }
            else if (BMI <= 16)
            {
                B = "痩せ";
            }

            DisplayAlert("BMI", BMI.ToString() + "\n" + B + "です", "OK");
        }
    }
}
