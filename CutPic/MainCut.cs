using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutPic
{
    public partial class PicCut : Form
    {
        

        CutPic cutter = null;
        public PicCut()
        {
            InitializeComponent();
           
        }

        #region 注册热键
        /// <summary>
        /// 如果函数执行成功，返回值不为0。
        /// 如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        /// </summary>
        /// <param name="hWnd">要定义热键的窗口的句柄</param>
        /// <param name="id">定义热键ID（不能与其它ID重复）</param>
        /// <param name="fsModifiers">标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效</param>
        /// <param name="vk">定义热键的内容</param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        /// <summary>
        /// 注销热键
        /// </summary>
        /// <param name="hWnd">要取消热键的窗口的句柄</param>
        /// <param name="id">要取消热键的ID</param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// 辅助键名称。
        /// Alt, Ctrl, Shift, WindowsKey
        /// </summary>
        [Flags()]
        public enum KeyModifiers { None = 0, Alt = 1, Ctrl = 2, Shift = 4, WindowsKey = 8 }

        /// <summary>
        /// 注册热键
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="hotKey_id">热键ID</param>
        /// <param name="keyModifiers">组合键</param>
        /// <param name="key">热键</param>
        public static void RegHotKey(IntPtr hwnd, int hotKeyId, KeyModifiers keyModifiers, Keys key)
        {
            if (!RegisterHotKey(hwnd, hotKeyId, keyModifiers, key))
            {
                int errorCode = Marshal.GetLastWin32Error();
                if (errorCode == 1409)
                {
                    MessageBox.Show("热键被占用 ！");
                }
                else
                {
                    MessageBox.Show("注册热键失败！错误代码：" + errorCode);
                }
            }
        }

        /// <summary>
        /// 注销热键
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="hotKey_id">热键ID</param>
        public static void UnRegHotKey(IntPtr hwnd, int hotKeyId)
        {
            //注销指定的热键
            UnregisterHotKey(hwnd, hotKeyId);
        }
        #endregion
        private void PicCut_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       
           NumberCbox.SelectedIndex = CutPicSet.Default.KeyNumber;            
        }

        private void PicCut_SizeChanged(object sender, EventArgs e)
        {
           if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                MinNot.Visible = true;
            }
        }

        private void MinNot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                ShowCutPic();
            }
        }

        protected void ShowCutPic()
        {
            Bitmap CatchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            // 创建一个画板，让我们可以在画板上画图
            // 这个画板也就是和屏幕大小一样大的图片
            // 我们可以通过Graphics这个类在这个空白图片上画图
            Graphics g = Graphics.FromImage(CatchBmp);
            // 把屏幕图片拷贝到我们创建的空白图片 CatchBmp中
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));

            cutter = new CutPic();

            // 创建截图窗体
            //   cutter = new Cutter();
            cutter.Image = CatchBmp;
            cutter.ShowDialog();
        }
        private void MinNot_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right)
            {
                this.Show();
                MinNot.Visible = false;
                this.WindowState = FormWindowState.Normal;
               
            }
                   
        }


        private const int WM_HOTKEY = 0x312; //窗口消息-热键
        private const int WM_CREATE = 0x1; //窗口消息-创建
        private const int WM_DESTROY = 0x2; //窗口消息-销毁
        private const int Space = 0x3572; //热键ID
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID
                    switch (m.WParam.ToInt32())
                    {
                        case Space: //热键ID
                            ShowCutPic();
                            break;
                        default:
                            break;
                    }
                    break;
                case WM_CREATE: //窗口消息-创建
                    SetHotKey(CutPicSet.Default.KeyNumber);
                    break;
                case WM_DESTROY: //窗口消息-销毁
                    UnRegHotKey(Handle, Space); //销毁热键
                    break;
                default:
                    break;
            }
        }

        public void SetHotKey(int keynumber)
        {
            if (keynumber == 0)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D0);
            }
            else if (keynumber == 1)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D1);
            }
            else if (keynumber == 2)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D2);
            }
            else if (keynumber == 3)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D3);
            }
            else if (keynumber == 4)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D4);
            }
            else if (keynumber == 5)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D5);
            }
            else if (keynumber == 6)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D6);
            }
            else if (keynumber == 7)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D7);
            }
            else if (keynumber == 8)
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D8);
            }
            else
            {
                RegHotKey(Handle, Space, KeyModifiers.Ctrl, Keys.D9);
            }
        }
        private void NumberCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CutPicSet.Default.KeyNumber = NumberCbox.SelectedIndex;
            CutPicSet.Default.Save();
            UnRegHotKey(Handle, Space);
            SetHotKey(NumberCbox.SelectedIndex);
           // CutPicSet.Default.KeyNumber.

        }

        

       

      
    }
}
