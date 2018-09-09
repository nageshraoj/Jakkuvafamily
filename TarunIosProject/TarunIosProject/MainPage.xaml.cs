using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TarunIosProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
           // bool tet = true;
           
        }
        public static int a = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            CheckCondition(a);
            a++;
            if (a > 3) a = 0;
          /*  switch (a)
            {
                case 0:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                case 1:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                case 2:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                case 3:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                case 4:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                case 5:
                    a++;
                    label.Text = "Cliciked " + Convert.ToString(a) + " Times";
                    break;
                default:
                    a = 0;
                    label.Text = "Count is resetting";
                    break;
            }*/


          
        }
        public void CheckCondition(int InValue)
        {


          /*  if (InValue ==0)
                label.Text = "The value is 0";
            else
            {
                if (InValue == 1)
                {
                    label.Text = "The value is 1";
                }
                else
                {
                    if(InValue ==2)
                    {
                        label.Text = "The value is 2";
                    }
                    else
                    {
                        label.Text = "The value is more than 2";
                    }
                }

            } */

            switch (InValue)
            {
                case 0:
                    label.Text = "The value is  0";
                    break;
                case 1:
                    label.Text = "The value is  1";
                    break;
                case 2:
                    label.Text = "The value is 2";
                    break;
                case 3:
                    label.Text = "The value is 3";
                    break;
                default:
                    label.Text = "The value is something else";
                    break;
            }




        }
    }
}
