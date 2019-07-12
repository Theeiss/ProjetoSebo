﻿using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class TextBoxData : MaskedTextBox
    {

        public DateTime Data { get; set; }

        public TextBoxData()
        {
            this.Mask = "00/00/0000";
        }

        protected override void OnLeave(EventArgs e)
        {
            CalcularDataHora();

            base.OnLeave(e);
        }

        private void CalcularDataHora()
        {
            try
            {
                this.Data = Convert.ToDateTime(this.Text);
            }
            catch (Exception)
            {
                this.Data = DateTime.MinValue;
                this.Clear();
            }
        }
    }
}
