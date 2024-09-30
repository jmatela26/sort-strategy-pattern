using StringSorterApp.Abstracts;
using StringSorterApp.Controllers;
using StringSorterApp.Dto;
using StringSorterApp.Enums;
using StringSorterApp.Models;
using StringSorterApp.Service.ButtonSortService;
using StringSorterApp.Service.SortService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StringSorterApp
{
    public partial class Form1 : Form
    {
        private readonly SortService _sortService;
        public Form1()
        {
            InitializeComponent();
            _sortService = new SortService();
            Seeding();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbSortingStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Seeding()
        {
            // Bind enum to the ComboBox
            cmbSortingStrategy.DataSource = Enum.GetValues(typeof(SortStrategyType));

            // Default selected index
            cmbSortingStrategy.SelectedIndex = 0;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            // Create a SortRequestDto
            var sortRequestDto = new SortRequestDto
            {
                InputString = input,
                SortStrategy = (SortStrategyType)cmbSortingStrategy.SelectedItem
            };

            // Call a method to handle sorting and receive SortResponseDto
            var result = _sortService.SortString(sortRequestDto);

            // Display the sorted string in the label
            lblResult.Text = result.SortedString;
        }
    }
}
