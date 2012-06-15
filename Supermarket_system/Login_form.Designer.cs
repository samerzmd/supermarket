namespace Supermarket_system
{
    partial class Login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.username_f = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.password_f = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundRectShapeForm
            // 
            this.roundRectShapeForm.Radius = 50;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(258, 263);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(93, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "دخول";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // username_f
            // 
            // 
            // 
            // 
            this.username_f.Border.Class = "TextBoxBorder";
            this.username_f.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.username_f.Location = new System.Drawing.Point(207, 152);
            this.username_f.Name = "username_f";
            this.username_f.Size = new System.Drawing.Size(194, 20);
            this.username_f.TabIndex = 4;
            this.username_f.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.superValidator1.SetValidator1(this.username_f, this.requiredFieldValidator2);
            this.username_f.WatermarkText = "ادخل اسم المستحدم";
            // 
            // password_f
            // 
            // 
            // 
            // 
            this.password_f.Border.Class = "TextBoxBorder";
            this.password_f.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.password_f.Location = new System.Drawing.Point(207, 224);
            this.password_f.Name = "password_f";
            this.password_f.Size = new System.Drawing.Size(194, 20);
            this.password_f.TabIndex = 5;
            this.password_f.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.password_f.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.password_f, this.requiredFieldValidator1);
            this.password_f.WatermarkText = "ادخل كلمة المرور";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.password_f);
            this.Controls.Add(this.username_f);
            this.Controls.Add(this.buttonX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.Name = "Login_form";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loding_form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX username_f;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private DevComponents.DotNetBar.Controls.TextBoxX password_f;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
    }
}
