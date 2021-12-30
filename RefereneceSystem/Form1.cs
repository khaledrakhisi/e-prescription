using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefereneceSystem
{
    public partial class frm_refereneceSystem : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Timer timer1 = new Timer();
        private int timeElapsed = 0;
        private int colorSchemeIndex;

        public frm_refereneceSystem()
        {
            InitializeComponent();


            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink100, TextShade.WHITE);

            seedListView();
            seedListView1();
            seedListView2();
            seedListView3();
            seedListView7();

            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void seedListView()
        {
            //Define
            var data = new[]
            {
                new []{"M00/M99", "تشخیص اولیه تستی", "اولیه", "1399/10/25", "توضیحات تکمیلی"},
                new []{"M00/M99", "تشخیص اولیه تستی", "اولیه", "1399/10/25", "توضیحات تکمیلی"},
                new []{"M00/M99", "تشخیص اولیه تستی", "اولیه", "1399/10/25", "توضیحات تکمیلی"},
                new []{"M00/M99", "تشخیص اولیه تستی", "اولیه", "1399/10/25", "توضیحات تکمیلی"},

            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView_detectLevel1.Items.Add(item);
            }
        }

        private void seedListView1()
        {
            //Define
            var data = new[]
            {
                new []{"1", "AZITHROMYCIN DIHYDRATE 500MG TAB" },
                new []{"2", "CEFIXIME 400MG TAB" },
                new []{"3", "CLOTRIMAZOLE 1% 15G TOP CREAM" },
                new []{"4", "FOLIC ACID 1MG TAB" },

            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
                materialListView4.Items.Add(new ListViewItem(version));
            }
        }

        private void seedListView2()
        {
            //Define
            var data = new[]
            {
                new []{"1", "سیاهی دور چشم ها" , "زیر چشم ها"},
                new []{"2", "زانو درد شدید شب هنگام" , "زانو ها"},
                new []{"3", "درد" ,"شکم"},
                new []{"4", "کم خوابی" ,"--"},

            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                //materialListView2.Items.Add(item);
                materialListView5.Items.Add(new ListViewItem(version));
            }
        }

        private void seedListView3()
        {
            //Define
            var data = new[]
            {
                new []{"1", "دیابت" ,"فرزند"},
                new []{"2", "بیماری 2" , "پدر"},
                new []{"3", "بیماری 3" ,"خواهر"},

            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView3.Items.Add(item);
                materialListView6.Items.Add(new ListViewItem(version));
            }
        }

        private void seedListView7()
        {
            //Define
            var data = new[]
            {
                new []{"1", "1399/11/10" ,"دکتر علی چلداوی", "12345", "پزشک عمومی", "شکم درد"},
                new []{"2", "1399/11/09" ,"دکتر رسول معاوی", "56743", "پزشک عمومی", "اسهال شدید"},
                new []{"3", "1399/11/08" ,"دکتر حبیب حسیبی", "769878", "پزشک عمومی", "سرفه"},

            };

            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView7.Items.Add(item);
                materialListView2.Items.Add(new ListViewItem(version));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialTabControl_main.SelectedIndex = 4;//
            materialComboBox2.SelectedIndex = 0;//
            materialComboBox1.SelectedIndex = 0;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string s_selectedKind = "";
            s_selectedKind = materialRadioButton3.Checked ? "نهایی" : (materialRadioButton2.Checked ? "حین درمان" : "اولیه");

            var item = new ListViewItem(new[] { "M00/M99",comboBox1.Text, s_selectedKind, dateTimePicker1.Value.ToShortDateString() ,materialTextBox1.Text});
            materialListView__detectLevel2.Items.Add(item);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.Animate(materialCard1, Util.Effect.Slide, 10, 20);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            materialTabControl_main.SelectedIndex = 2;//سوابق دارویی
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            materialTabControl_main.SelectedIndex = 1;//اطلاعات پزشکی
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources._9e917f152f70800d105c76ceb7ac2b362_2;
            pictureBox5.Visible = true;

            timer1.Enabled = true; 
            timer1.Start();
            timer1.Interval = 10; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            
            //materialProgressBar1.Value++;
            //if (materialProgressBar1.Value >= 100)
            //{
            //    timer1.Stop();

            //    materialLabel3.Text = "بازخوراند با موفقیت ارسال شد";
            //}
            if(timeElapsed >= 200)
            {
                timer1.Stop();
                materialLabel13.Text = "بازخوراند با موفقیت ارسال شد";
                timeElapsed = 0;                
                pictureBox5.Image = Properties.Resources._9136df0949a40e6567c6f4f7a634367222;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            materialTabControl_main.SelectedIndex = 3;//اطلاعات ارجاع
        }

        public static Color ToColor(int argb)
        {
            return Color.FromArgb(
                (argb & 0xff0000) >> 16,
                (argb & 0xff00) >> 8,
                 argb & 0xff);
        }

        private Bitmap ChangeImageColor(Bitmap bitmap, Color newColor)
        {
            Color originalColor;
            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    originalColor = bitmap.GetPixel(i, j);
                    if (originalColor.A > 150)
                    {
                        newBitmap.SetPixel(i, j, newColor);
                    }
                    else
                    {
                        newBitmap.SetPixel(i, j, originalColor);
                    }
                }
            }

            return newBitmap;
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void changePictureboxesImage(Color newColor)
        {
            //foreach (var pb in materialTabControl_main.Controls.OfType<PictureBox>())
            //{
            //    pb.Image = ChangeImageColor((Bitmap)pb.Image, newColor);
            //}


            // Iterates throught all the tabs in the tab control.
            //foreach (Control tab in materialTabControl_main.Controls)
            //{
            //    TabPage tabPage = (TabPage)tab;

            //    // Iterates through all the controls (i.e. textboxes, buttons, labels, etc.) in the tab page.
            //    foreach (var pb in tabPage.Controls.OfType<PictureBox>())
            //    {
            //        pb.Image = ChangeImageColor((Bitmap)pb.Image, newColor);
            //    }
            //}


            foreach (PictureBox pb in GetAll(this, typeof(PictureBox)))
            {
                if((string)pb.Tag != "unchangeable")
                    pb.Image = ChangeImageColor((Bitmap)pb.Image, newColor);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                colorSchemeIndex++;
                if (colorSchemeIndex > 4) colorSchemeIndex = 0;

                //These are just example color schemes
                switch (colorSchemeIndex)
                {
                    case 0:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                        changePictureboxesImage(ToColor((int)Primary.BlueGrey800));

                        break;
                    case 1:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                        changePictureboxesImage(ToColor((int)Primary.Green600));

                        break;
                    case 2:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                        changePictureboxesImage(ToColor((int)Primary.Indigo500));

                        break;
                    case 3:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Red700, Primary.Yellow900, Accent.Amber400, TextShade.WHITE);
                        changePictureboxesImage(ToColor((int)Primary.Orange700));

                        break;
                    case 4:
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Purple300, Primary.Brown300, Accent.Lime700, TextShade.WHITE);
                        changePictureboxesImage(ToColor((int)Primary.Cyan700));

                        break;
                }
                this.Refresh();
            }
            catch
            {

            }
        }

        private void MaterialTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(materialComboBox1.SelectedIndex == 0)
                    materialLabel8.Text = DateTime.Now.AddDays(double.Parse(materialTextBox2.Text)).ToShortDateString();

                else if (materialComboBox1.SelectedIndex == 1)
                    materialLabel8.Text = DateTime.Now.AddDays(double.Parse(materialTextBox2.Text)*7).ToShortDateString();

                else if (materialComboBox1.SelectedIndex == 2)
                    materialLabel8.Text = DateTime.Now.AddMonths(int.Parse(materialTextBox2.Text)).ToShortDateString();
            }
            catch
            {

            }
        }
    }
}
