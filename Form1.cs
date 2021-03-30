//源码由玩家 @诶嘿的囊大呦！ 编写。
//allrights reserved
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using KHook;
using System.Threading;

namespace GenshinComposer
{
    public partial class Form1 : Form
    {
        public bool enabled = false;

        public Form1()
        {
            InitializeComponent();
            KeyboardHook k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下 
            k_hook.Start();//安装键盘钩子
            enabled = true;
            MessageBox.Show("按下 Ctrl+小键盘0 以退出程序。\n按下 Ctrl+小键盘9 以挂起/激活程序\n按下小键盘1至7弹奏中音\n按下Ctrl+小键盘1至7弹奏高音\n按下Alt +小键盘1至7弹奏低音\n\n\n 源码由玩家 @诶嘿的囊大呦！ 编写\n 仅供交流，切勿商用。");
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.NumPad0 && (int)Control.ModifierKeys == (int)Keys.Control) 
            {
                Application.ExitThread();//按下Ctrl+0直接关闭
            }
            if (e.KeyValue == (int)Keys.NumPad9 && (int)Control.ModifierKeys == (int)Keys.Control)
            {
                enabled = !enabled;
            }
            if (enabled == true)
            {
                if (e.KeyValue == (int)Keys.NumPad1 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{Q}");
                }
                if (e.KeyValue == (int)Keys.NumPad2 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{W}");
                }
                if (e.KeyValue == (int)Keys.NumPad3 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{E}");
                }
                if (e.KeyValue == (int)Keys.NumPad4 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{R}");
                }
                if (e.KeyValue == (int)Keys.NumPad5 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{T}");
                }
                if (e.KeyValue == (int)Keys.NumPad6 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{Y}");
                }
                if (e.KeyValue == (int)Keys.NumPad7 && (int)Control.ModifierKeys == (int)Keys.Control)
                {
                    SendKeys.Send("{U}");
                }
                if (e.KeyValue == (int)Keys.NumPad1 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{Z}");
                }
                if (e.KeyValue == (int)Keys.NumPad2 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{X}");
                }
                if (e.KeyValue == (int)Keys.NumPad3 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{C}");
                }
                if (e.KeyValue == (int)Keys.NumPad4 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{V}");
                }
                if (e.KeyValue == (int)Keys.NumPad5 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{B}");
                }
                if (e.KeyValue == (int)Keys.NumPad6 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{N}");
                }
                if (e.KeyValue == (int)Keys.NumPad7 && (int)Control.ModifierKeys == (int)Keys.Alt)
                {
                    SendKeys.Send("{M}");
                }
                if (e.KeyValue == (int)Keys.NumPad1 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{A}");
                }
                if (e.KeyValue == (int)Keys.NumPad2 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{S}");
                }
                if (e.KeyValue == (int)Keys.NumPad3 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{D}");
                }
                if (e.KeyValue == (int)Keys.NumPad4 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{F}");
                }
                if (e.KeyValue == (int)Keys.NumPad5 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{G}");
                }
                if (e.KeyValue == (int)Keys.NumPad6 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{H}");
                }
                if (e.KeyValue == (int)Keys.NumPad7 && Control.ModifierKeys == 0)
                {
                    SendKeys.Send("{J}");
                }
            }
        }
    }
}
