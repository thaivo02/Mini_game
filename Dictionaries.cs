using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_game
{
    public partial class Dictionaries : Form
    {
        public Dictionaries()
        {
            InitializeComponent();

            DataTable _dataTable = new DataTable();

            String[] Fruits_en = { "avocado", "coconut", "dragonfruit", "grapes", "jackfruit", "lychee", "mango", "pineapple", "rambutan", "starfruit" };
            String[] Animals_en = { "bear", "deer", "donkey", "fox", "hippopotamus", "kangaroo", "lion", "ostrich", "panda", "turtle" };
            String[] Vehicles_en = { "airplane", "bicycle", "bus", "canoe", "helicopter", "motorbike", "taxi", "train", "truck", "van" };
            String[] Households_en = { "air conditioner", "bed", "couch", "curtains", "cushion", "sofa", "stove", "television", "wardrobe", "washing machine" };

            String[] Fruits_vie = { "trái bơ", "trái dừa", "trái thanh long", "trái nho", "trái mít", "trái vải", "trái xoài", "trái thơm", "trái chôm chôm", "trái khế" };
            String[] Animals_vie = { "con gấu", "con hươu", "con lừa", "con cáo", "con hà mã", "con chuột túi", "con sư tử", "con đà điểu", "con gấu trúc", "con rùa" };
            String[] Vehicles_vie = { "máy bay", "xe đạp", "xe buýt", "xuồng", "trực thăng", "xe gắn máy", "xe tắc xi", "tàu lửa", "xe tải", "xe bán tải" };
            String[] Households_vie = { "máy điều hòa", "cái giường", "cái ghế bố", "rèm cửa", "đệm ngồi", "ghế sô pha", "bếp", "tivi", "tủ quần áo", "máy giặt" };

            _dataTable.Columns.Add("Topic", typeof(string));
            _dataTable.Columns.Add("Vietnamese", typeof(string));
            _dataTable.Columns.Add("English", typeof(string));

            int count = 0;

            for (int i = count; i < Fruits_en.Length + count; i++)
                _dataTable.Rows.Add("Fruits", Fruits_vie[i], Fruits_en[i]);

            count += 10;

            for (int i = count; i < Animals_en.Length + count; i++)
                _dataTable.Rows.Add("Animals", Animals_vie[i - count], Animals_en[i - count]);

            count += 10;

            for (int i = count; i < Vehicles_en.Length + count ; i++)
                _dataTable.Rows.Add("Vehicles", Vehicles_vie[i - count], Vehicles_en[i - count]);

            count += 10;

            for (int i = count; i < Households_en.Length + count; i++)
                _dataTable.Rows.Add("Household things", Households_vie[i - count], Households_en[i - count]);

            grid_dict.DataSource = _dataTable;
        }
    }
}
