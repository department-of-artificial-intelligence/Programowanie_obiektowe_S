﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabSiedem.WpfApp
{
    public partial class Calculator : Window
    {
        float result, num1;
        int operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if(outbox.Text == "0")
            {
                outbox.Clear();
                outbox.Text += button.Content;
            }
            else {
                outbox.Text += button.Content;
            }
            
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            operation = 1;
        }
        
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if(outbox.Text != "")
            {
                num1 = float.Parse(outbox.Text);
                outbox.Clear();
                operation = 2;
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            operation = 3;
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(outbox.Text);
            outbox.Clear();
            operation = 4;
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case 1:
                    result = num1 + float.Parse(outbox.Text);
                    outbox.Text = result.ToString();
                    break;

                case 2:
                    result = num1 - float.Parse(outbox.Text);
                    outbox.Text = result.ToString();
                    break;

                case 3:
                    result = num1 / float.Parse(outbox.Text);
                    outbox.Text = result.ToString();
                    break;

                case 4:
                    result = num1 * float.Parse(outbox.Text);
                    outbox.Text = result.ToString();
                    break;
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            result = 0;
            operation = '0';
            outbox.Text = "0";
        }
    }
}