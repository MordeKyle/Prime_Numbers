using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Program: Prime Numbers
  Author: Kyle McBride A02609917
  Date: 03/26/2014
  Description: Program will determine if user entered number is prime or not.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Prime_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean isPrime(int userInput)
        {
            if (userInput > 0 && userInput <= 3) //check to see if user input is number 1, 2 or 3
            {
                return true;
            }
            else if (userInput % 2 == 0) //check to see if number is even
            {
                return false;
            }
            else
            { //if preceding two conditions are both false, start dividing number to see if it is divisible by anything
                //but itself and 1 or 2.
                for (int loopCounter = 3; loopCounter < userInput; loopCounter++)
                {
                    if (userInput % loopCounter == 0)
                    {
                        return false;
                    }
                } 
            }
            return true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int userInput = int.Parse(userInputTxt.Text); //pull user entered value from userInputTxt and assigning it to int.

            if (isPrime(userInput)) //passing userInput int into isPrime method and checking if it is true.
            {
                MessageBox.Show(userInput + " " + "is a prime number!"); //display result of true return from isPrime
            }
            else
            {
                MessageBox.Show(userInput + " " + "is not a prime number."); //display results of false raturn from isPrime
            }
        }
    }
}
