/******************************** Module Header ********************************\
Module Name:  MainForm.cs
Project:      CSWinFormLayeredWindow
Copyright (c) Microsoft Corporation.



This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*******************************************************************************/

#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.praim.altTab.Properties;
#endregion


namespace com.praim.altTab
{
    public partial class StandardForm : Form
    {
        AltTab altTab;
        public StandardForm(int size, Point p)
        {
            altTab = new AltTab();
            StartPosition = FormStartPosition.Manual;
            this.Location = p;
            InitializeComponent();
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            this.Height = screenRectangle.Top - this.Top + size;
            this.Width = size;
        }

        private void StandardForm_Click(object sender, EventArgs e)
        {
            altTab.nextWindow();
        }

        private void StandardForm_MouseClick(object sender, MouseEventArgs e)
        {
            altTab.nextWindow();
        }
    }
}