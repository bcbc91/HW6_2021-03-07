using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lectures.Business;
using Lectures.DataAccess;
using Lectures.DataAccess.Bases;
using Lectures.Models;

namespace Lectures
{
    public partial class Form1 : Form
    {
        private LectureService lectureService ;
        public Form1()
        {
            //Newlediğim service e göre hem file hem memory çalışmaktadır.
            InitializeComponent();
            OperationBase operationBase =
                new FileOperations(Application.StartupPath.Replace("bin\\Debug", "Data") + @"\LectureData.txt");
            lectureService = new LectureService(operationBase);
        }

        public void FillCredits()
        {
            
            List<Credit> credits = new List<Credit>();

            credits.Add(new Credit(){Value = (int)Enums.Credit.FiveCredits,Text = GetDescription(Enums.Credit.FiveCredits) });
            //credits.Add(new Credit() { Value = (int)Enums.Credit.FourCredits, Text = Enums.Credit.FiveCredits });
            credits.Add(new Credit(){Value = (int)Enums.Credit.FourCredits,Text = GetDescription(Enums.Credit.FourCredits) });
            credits.Add(new Credit(){Value = (int)Enums.Credit.ThreeCredits,Text = GetDescription(Enums.Credit.ThreeCredits) });
            credits.Add(new Credit(){Value = (int)Enums.Credit.TwoCredits,Text = GetDescription(Enums.Credit.TwoCredits) });
            credits.Add(new Credit(){Value = (int)Enums.Credit.OneCredit,Text = GetDescription(Enums.Credit.OneCredit) });
            credits.Insert(0,new Credit(){Value = 0,Text = "--Seçiniz--"});
            ddlKredisi.DataSource = credits;
           
            ddlKredisi.ValueMember = "Value";
            ddlKredisi.DisplayMember = "Text";

        }
        public static string GetDescription( Enum value)
        {
            return ((DescriptionAttribute)Attribute.GetCustomAttribute(
                value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static)
                    .Single(x => x.GetValue(null).Equals(value)),
                typeof(DescriptionAttribute)))?.Description ?? value.ToString();
        }

        public void FillCategories()
        {
            
            List<Category> categories = new List<Category>();
            
            categories.Add(new Category(){Value = (int)Enums.Category.Sayısal,Text = Enums.Category.Sayısal.ToString()});
            categories.Add(new Category(){Value = (int)Enums.Category.Sözel,Text = Enums.Category.Sözel.ToString()});
            categories.Insert(0,new Category(){Value = 0,Text = "--Seçiniz--"});
            ddlKategorisi.DataSource = categories;
            ddlKategorisi.ValueMember = "Value";
            ddlKategorisi.DisplayMember = "Text";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCredits();
            FillCategories();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvLectures.DataSource = lectureService.Get().ToList();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                MessageBox.Show("Geçerli veri giriniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbIcerigi.Text))
            {
                MessageBox.Show("Geçerli veri giriniz.");
                return;
            }
            if (Convert.ToInt32(ddlKredisi.SelectedValue)==0)
            {
                MessageBox.Show("Seçim yapınız.");
                return;
            }
            if (Convert.ToInt32(ddlKategorisi.SelectedValue) == 0)
            {
                MessageBox.Show("Seçim Yapınız.");
                return;
            }

            Lecture lecture = new Lecture()
            {
                LectureName = tbAdi.Text.Trim(),
                Content = tbIcerigi.Text.Trim(),
                Credit = (Enums.Credit) ddlKredisi.SelectedValue,
                Category = (Enums.Category) ddlKategorisi.SelectedValue
            };
            lectureService.Add(lecture);
            FillGrid();
        }
    }
}
