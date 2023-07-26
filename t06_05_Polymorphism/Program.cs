﻿namespace t06_05_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();

            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }
    }
}