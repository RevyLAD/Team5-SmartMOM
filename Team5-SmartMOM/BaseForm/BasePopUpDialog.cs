using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public struct POINT { public int x, y; }
    public partial class BasePopUpDialog : Form
    {
        public BasePopUpDialog()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.dll")] // 현재 마우스 위치를 얻기위한 API함수.
        public extern static void GetCursorPos(out POINT point);

        Point FormLocation; // 현재 폼 위치
        POINT LastLocation = new POINT(); // 방금 전의 마우스 위치
        POINT CurrentLocation = new POINT(); // 현재 마우스 위치
                                             // 폼이 움직일 양 = CurrentLocation - LastLocation.
        bool IsMouseMoveStart = false; // 현재 마우스 움직이기 기능이 켜져있는가.
                                       // 만약 이게 없으면 그냥 폼위에서 마우스가 움직이면 폼이 움직이게 될거임.

        private void form1_MouseDown(object sender, MouseEventArgs e)
        {
            GetCursorPos(out CurrentLocation);
            FormLocation = this.Location;
            IsMouseMoveStart = true;
        }
        private void form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스의 움직임에 맞춰서 폼을 움직인다.

            if (!IsMouseMoveStart) return;

            GetCursorPos(out LastLocation);
            FormLocation.X -= (CurrentLocation.x - LastLocation.x);
            FormLocation.Y -= (CurrentLocation.y - LastLocation.y);
            this.Location = FormLocation;
            CurrentLocation = LastLocation;
        }
        private void form1_MousUp(object sender, MouseEventArgs e)
        {
            IsMouseMoveStart = false;
        }
    }


}
