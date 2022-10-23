using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1214058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Mouse";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }

            if (rbMonitor.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Mouse";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }

            if (rbPrinter.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Mouse";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }

            if (rbKeyboard.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Mouse";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }

            if (rbScanner.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Mouse";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Monitor";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Printer";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tsIKetGambar.Text = "Cocok! ini adalah gambar Keyboard";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }
        }

        private void tsbScsnner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
               tsIKetGambar.Text = "Cocok! ini adalah gambar Scanner";
            }
            else
            {
                tsIKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah";
            }
        }
    }
}
