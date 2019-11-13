using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KalkulatorPolPowirzchni.Models;

namespace KalkulatorPolPowirzchni
{

    public partial class Default : System.Web.UI.Page
    {
        public void selectChanged(object sender, EventArgs args)
        {
            var figure = figuresNames.SelectedValue;
           
            switch (figure)
            {
                case "Kwadrat":
                    funcLabel.Text = "a (bok)";
                    break;

                case "Prostokąt":
                    funcLabel.Text = "a b (bok) (bok)";
                    break;
                case "Trójkąt":
                    funcLabel.Text = "a h (podstawa) (wysokość)";
                    break;
                case "Trójkąt równoramienny":
                    funcLabel.Text = "a (ramię - jedno z dwóch takich samych)";
                    break;
                case "Trójkąt prostokątny":
                    funcLabel.Text = "a b (przyprostokątna) (przyprostokątna)";
                    break;
                case "Trapez":
                    funcLabel.Text = "a b h (podstawa) (podstawa) (wysokość)";
                    break;
                case "Okrąg":
                    funcLabel.Text = "r (promień)";
                    break;
            }
        }

        public void calculate(object sender, EventArgs args)
        {
            try
            {
                var figure = figuresNames.SelectedValue;
                switch (figure)
                {
                    case "Kwadrat":
                        countedLabel.Text = "Pole powierzchni kwadratu wynosi: " + new Square().calculateArea(float.Parse(txtBoxValues.Text)).ToString();
                        break;

                    case "Prostokąt":
                        countedLabel.Text = "Pole powierzchni prostokąta wynosi: " + divideTextForValues(2, txtBoxValues.Text, "rect").ToString();
                        break;

                    case "Trójkąt":
                        countedLabel.Text = "Pole powierzchni trójkąta wynosi: " + divideTextForValues(2, txtBoxValues.Text, "tria").ToString();
                        break;

                    case "Trójkąt równoramienny":
                        countedLabel.Text = "Pole powierzchni trójkąta równoramiennego wynosi: " + new IsoscelesTriangle().calculateArea(float.Parse(txtBoxValues.Text)).ToString();
                        break;

                    case "Trójkąt równoboczny":
                        countedLabel.Text = "Pole powierzchni trójkąta równobocznego wynosi: " + new EquilateralTriangle().calculateArea(float.Parse(txtBoxValues.Text)).ToString();
                        break;

                    case "Trójkąt prostokątny":
                        countedLabel.Text = "Pole powierzchni trójkąta prostokątnego wynosi: " + divideTextForValues(2, txtBoxValues.Text, "rtri").ToString();
                        break;

                    case "Trapez":
                        countedLabel.Text = "Pole powierzchni trapezu wynosi: " + divideTextForValues(3, txtBoxValues.Text, "trap").ToString();
                        break;

                    case "Okrąg":
                        countedLabel.Text = "Pole powierzchni okręgu wynosi: " + new Circle().calculateArea(float.Parse(txtBoxValues.Text)).ToString();
                        break;
                }
            }
            catch
            {

            }
            

        }

        public static float divideTextForValues(int howManyV, string valueString, string whichFigure)
        {

            float a, b, c = 0f;
            string newValue = "";
            for(int i = 0; i < valueString.Length; i++)
            {
                if(valueString[i] == ',')
                {
                    newValue += '.';
                }
                else
                {
                    newValue += valueString[i];
                }
            }
            string[] values = newValue.Split(' ');
            if(howManyV == 2)
            {
                a = float.Parse(values[0], CultureInfo.InvariantCulture.NumberFormat);
                b = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                a = float.Parse(values[0], CultureInfo.InvariantCulture.NumberFormat);
                b = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
                c = float.Parse(values[2], CultureInfo.InvariantCulture.NumberFormat);
            }

            switch (whichFigure)
            {
                case "rect":
                    return new Rectangle().calculateArea(a, b);
                case "tria":
                    return new Triangle().calculateArea(a, b);
                case "rtri":
                    return new RectangularTriangle().calculateArea(a, b);
                case "trap":
                    return new Trapeze().calculateArea(a, b, c);
            }



            return 0f;


        }
    }
}
