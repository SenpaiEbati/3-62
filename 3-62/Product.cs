using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_62
{
    class Product
    {
        private string _Name;
        private string _Color;
        private double _Weight;
        List<Product> _List;

        public Product(string Name, string Color, double Weight, List<Product> List)
        {
            if (Name != null && Name.Trim() != "")
                _Name = Name.Trim();
            else
                throw new Exception("Название товара должено быть задано");

            if (Color != null && Color.Trim() != string.Empty)
                _Color = Color.Trim();
            else
                throw new Exception("Цвет товара должен быть задан");

            if (Weight >= 0.1 && Weight <= 100.0)
                _Weight = Weight;
            else
                throw new Exception("Вес должен быть в диапозоне 0.1...100");

            _List = List;

            if (_List != null)
            {
                Product[] Temp = (from p in _List
                                  where p._Name == Name.Trim() && p._Color == Color.Trim()
                                  select p).ToArray();
                if (Temp.Length > 0)
                    throw new Exception("Такая комбинация название и цвет товара уже есть");
            }
        }

        public Product(List<Product> CheckList): this("Не задано", "Не задано", 0.1, CheckList) { }

        public Product() : this("Не задано", "Не задано", 0.1, null) { }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != null && value.Trim() != "")
                {
                    value = value.Trim();
                    if (_Name != value)
                    {
                        if (_List != null)
                        {
                            Product[] Temp = (from p in _List
                                              where p._Name == value && p._Color == _Color
                                              select p).ToArray();
                            if (Temp.Length > 0)
                                throw new Exception("Такая комбинация название и цвет товара уже есть");
                        }
                        _Name = value;
                    }
                }
            }
        }

        public string Color
        {
            get { return _Color; }
            set 
            { 
                if (value != null && value.Trim() != "")
                {
                    value = value.Trim();
                    if (_Color != value)
                    {
                        if (_List != null)
                        {
                            Product[] Temp = (from p in _List
                                              where p._Name == _Name && p._Color == value
                                              select p).ToArray();
                            if (Temp.Length > 0)
                                throw new Exception("Такая комбинация название и цвет товара уже есть");
                        }
                        _Color = value;
                    }
                }
            }
        }

        public double Weight
        {
            get { return _Weight; }
            set
            {
                if (value >= 0.1 && value <= 100 && _Weight != value)
                {
                    _Weight = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{_Name} ({_Color}),{_Weight}";
        }
    }
}
