using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_62
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private List<Product> Products = new List<Product>();

        private void Main_F_Load(object sender, EventArgs e)
        {
            ProductBS.DataSource = Products;
            Product_DGV.DataSource = ProductBS;
            Result_DGV.DataSource = ResultBS;
        }

        private void AddProduct_B_Click(object sender, EventArgs e)
        {
            int key = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(NameProduct_TB.Text))
                    throw new Exception("Не введено название товара");
                if (string.IsNullOrWhiteSpace(ColorProduct_TB.Text))
                    throw new Exception("Не введено название цвета товара");
                key = 2;
                if (Convert.ToDouble(WeightProduct_NUD.Value) < 0.1 || Convert.ToDouble(WeightProduct_NUD.Value) > 100.0)
                    throw new Exception("Вес должен быть в диапозоне 0.1...100");
                Products.Add(new Product(NameProduct_TB.Text, ColorProduct_TB.Text,
                    Convert.ToDouble(WeightProduct_NUD.Value), Products));
                ProductBS.ResetBindings(false);
            }
            catch (Exception E)
            {
                switch (key)
                {
                    case 0:
                        NameProduct_TB.Focus();
                        break;
                    case 1:
                        ColorProduct_TB.Focus();
                        break;
                    case 2:
                        WeightProduct_NUD.Focus();
                        break;
                }
                MessageBox.Show(E.Message, "Требуется исправление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelProduct_B_Click(object sender, EventArgs e)
        {
            if (ProductBS.Current != null)
            {
                Products.Remove(ProductBS.Current as Product);
                ProductBS.ResetBindings(false);
            }
            else
                MessageBox.Show("Не выбран человек", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetColumnNames()
        {
            for (int i = 0; i < Result_DGV.Columns.Count; i++)
            {
                switch (Result_DGV.Columns[i].DataPropertyName)
                {
                    case "Name":
                        Result_DGV.Columns[i].HeaderText = "Название товара";
                        break;
                    case "Color":
                        Result_DGV.Columns[i].HeaderText = "Цвет";
                        break;
                    case "Weight":
                        Result_DGV.Columns[i].HeaderText = "Вес";
                        break;
                }
            }
        }

        private void Where_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Where_TB.Text))
                {
                    Where_TB.Focus();
                    throw new Exception("Не введен цвет товара для отбора");
                }
                ResultBS.Clear();
                Product[] Temp = (from p in Products
                                  where p.Color == Where_TB.Text.Trim()
                                  select p).ToArray();
                foreach (var p in Temp)
                    ResultBS.Add(p);
                SetColumnNames();
                if (ResultBS.Count == 0)
                    MessageBox.Show("Не наден товар с заданым цветом", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E) {
                MessageBox.Show(E.Message, "Требуется исправление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sort_B_Click(object sender, EventArgs e)
        {
            if (ProductBS.Count > 0)
            {
                ResultBS.Clear();
                //Product[] Temp = Products.OrderByDescending(p => p.Weight).ThenBy(p => p.Name).ToArray();
                Product[] Temp = (from p in Products
                                  orderby p.Weight descending, p.Name ascending 
                                  select p).ToArray();
                foreach (var p in Temp)
                    ResultBS.Add(p);
                SetColumnNames();
            }
            else
                MessageBox.Show("Не введение люди", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Select_B_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(Select1_NUD.Value);
                double val2 = Convert.ToDouble(Select2_NUD.Value);
                if (val1 > 100 || val1 < 0.1)
                {
                    Select1_NUD.Focus();
                    throw new Exception("Первый число вышло за доступный диапазон 0.1...100");
                }
                if (val2 > 100 || val2 < 0.1)
                {
                    Select1_NUD.Focus();
                    throw new Exception("Второе число вышло за доступный диапазон 0.1...100");
                }
                ResultBS.Clear();
                
                var Temp = val1 < val2 ? (from p in Products
                            where p.Weight >= val1 && p.Weight <= val2
                            select new { Name = p.Name + "(" + p.Color + ")", Weight = p.Weight }).ToArray() :
                            (from p in Products
                                where p.Weight > val2 && p.Weight < val1
                                select new { Name = p.Name + "(" + p.Color + ")", Weight = p.Weight }).ToArray();
               
                foreach (var p in Temp)
                    ResultBS.Add(p);
                SetColumnNames();

                if (ResultBS.Count == 0)
                    MessageBox.Show("Не найдены товары с заданным диапазоном", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Требуется исправление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Group_B_Click(object sender, EventArgs e)
        {
            if (ProductBS.Count > 0)
            {
                ResultBS.Clear();
                var Temp = from p in Products
                           group p by p.Color into g
                           orderby g.Key ascending
                           select new
                           {
                               Color = g.Key,
                               SumN = g.Sum(v => v.Weight)
                           };
                foreach (var p in Temp)
                    ResultBS.Add(p);
                SetColumnNames();
            }
            else
                MessageBox.Show("Не введены товары", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products.Add(new Product(null,null,1,Products));
            ProductBS.ResetBindings(false);
        }
    }
}
