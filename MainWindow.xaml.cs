using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Azure.Communication;
using Azure.Communication.Sms;
using Azure.Communication.Identity;

namespace AzureComServiceSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "endpoint=https://acsworkdemo.communication.azure.com/;accesskey=iaguTNg97Tn1G3xxxxxAgyq8wcuJ/0xxxxxxtRuee1e2uw8RrEA2YOAOGcykc8lv5ShimoA==";
            SmsClient acsSmsClient = new SmsClient(connectionString);
            SendSmsResponse acsSmsResult = acsSmsClient.Send(
                            from: new PhoneNumber("+183xxxx9185"),
                            to: new PhoneNumber("+183xxxx190"),
                            message: "Hello SMS!! Powered By Azure Communication Services"
                          );

            MessageBox.Show($"Message Sent Successfully. Message ID{acsSmsResult.MessageId}");
      
        }


      //  new SendSmsOptions { EnableDeliveryReport = true } // optional
}
}
