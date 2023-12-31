﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App139
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if(m.Msg == 0x0f || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x13 )
            return false;
        
        Console.WriteLine(m.ToString() + m.Msg);
            if (m.Msg == 0x201)
                Application.Exit();
        
            return true;
        }
    }

    internal class MainApp : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp());
        }
    }
}
