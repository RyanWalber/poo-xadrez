
/*using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Joguinho_Xadrez
{
    partial class Form1 : Form
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Jogo de Xadrez";
            this.ResumeLayout(false);
        }
    }
}
*/

namespace Joguinho_Xadrez
{
    partial class Form1
    {
        /// <summary>
        /// Variável necessária para o designer de formulários.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar os recursos usados.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer do Windows Forms

        /// <summary>
        /// Método necessário para suportar o Designer.  
        /// Modificações no código podem ser feitas no editor do Designer.  
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpTabuleiro = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpTabuleiro
            // 
            this.tlpTabuleiro.ColumnCount = 8;
            this.tlpTabuleiro.RowCount = 8;
            for (int i = 0; i < 8; i++)
            {
                this.tlpTabuleiro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
                this.tlpTabuleiro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }
            this.tlpTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.tlpTabuleiro.Name = "tlpTabuleiro";
            this.tlpTabuleiro.Size = new System.Drawing.Size(600, 600);
            this.tlpTabuleiro.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tlpTabuleiro);
            this.Name = "Form1";
            this.Text = "Jogo de Xadrez";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTabuleiro;
    }
}


