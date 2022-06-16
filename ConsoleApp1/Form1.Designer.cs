namespace ConsoleApp1
{
    partial class Form1
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
            System.Windows.Forms.Label 書號Label;
            System.Windows.Forms.Label 書名Label;
            System.Windows.Forms.Label 出版日Label;
            System.Windows.Forms.Label 定價Label;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._p11_1dbDataSet = new ConsoleApp1._p11_1dbDataSet();
            this.書籍BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書籍TableAdapter = new ConsoleApp1._p11_1dbDataSetTableAdapters.書籍TableAdapter();
            this.書籍BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ConsoleApp1._p11_1dbDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.testdbDataSet = new ConsoleApp1.testdbDataSet();
            this.書籍資料TableAdapter1 = new ConsoleApp1.testdbDataSetTableAdapters.書籍資料TableAdapter();
            this.書籍資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new ConsoleApp1.testdbDataSetTableAdapters.TableAdapterManager();
            this.書號TextBox = new System.Windows.Forms.TextBox();
            this.書名TextBox = new System.Windows.Forms.TextBox();
            this.出版日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.定價TextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            書號Label = new System.Windows.Forms.Label();
            書名Label = new System.Windows.Forms.Label();
            出版日Label = new System.Windows.Forms.Label();
            定價Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this._p11_1dbDataSet;
            this.bindingSource1.Position = 0;
            // 
            // _p11_1dbDataSet
            // 
            this._p11_1dbDataSet.DataSetName = "_p11_1dbDataSet";
            this._p11_1dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 書籍BindingSource
            // 
            this.書籍BindingSource.DataSource = this.testdbDataSet;
            this.書籍BindingSource.Position = 0;
            // 
            // 書籍TableAdapter
            // 
            this.書籍TableAdapter.ClearBeforeFill = true;
            // 
            // 書籍BindingSource1
            // 
            this.書籍BindingSource1.DataSource = this.testdbDataSet;
            this.書籍BindingSource1.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ConsoleApp1._p11_1dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.書籍TableAdapter = this.書籍TableAdapter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "第一筆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "上一筆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "下一筆";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "最末筆";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 28);
            this.button5.TabIndex = 14;
            this.button5.Text = "新增";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "刪除";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(247, 280);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 28);
            this.button7.TabIndex = 16;
            this.button7.Text = "更新";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // testdbDataSet
            // 
            this.testdbDataSet.DataSetName = "testdbDataSet";
            this.testdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 書籍資料TableAdapter1
            // 
            this.書籍資料TableAdapter1.ClearBeforeFill = true;
            // 
            // 書籍資料BindingSource
            // 
            this.書籍資料BindingSource.DataMember = "書籍資料";
            this.書籍資料BindingSource.DataSource = this.testdbDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = ConsoleApp1.testdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.書籍資料TableAdapter = this.書籍資料TableAdapter1;
            // 
            // 書號Label
            // 
            書號Label.AutoSize = true;
            書號Label.Location = new System.Drawing.Point(84, 52);
            書號Label.Name = "書號Label";
            書號Label.Size = new System.Drawing.Size(41, 15);
            書號Label.TabIndex = 17;
            書號Label.Text = "書號:";
            // 
            // 書號TextBox
            // 
            this.書號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍資料BindingSource, "書號", true));
            this.書號TextBox.Location = new System.Drawing.Point(146, 49);
            this.書號TextBox.Name = "書號TextBox";
            this.書號TextBox.Size = new System.Drawing.Size(200, 25);
            this.書號TextBox.TabIndex = 18;
            // 
            // 書名Label
            // 
            書名Label.AutoSize = true;
            書名Label.Location = new System.Drawing.Point(84, 83);
            書名Label.Name = "書名Label";
            書名Label.Size = new System.Drawing.Size(41, 15);
            書名Label.TabIndex = 19;
            書名Label.Text = "書名:";
            // 
            // 書名TextBox
            // 
            this.書名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍資料BindingSource, "書名", true));
            this.書名TextBox.Location = new System.Drawing.Point(146, 80);
            this.書名TextBox.Name = "書名TextBox";
            this.書名TextBox.Size = new System.Drawing.Size(200, 25);
            this.書名TextBox.TabIndex = 20;
            // 
            // 出版日Label
            // 
            出版日Label.AutoSize = true;
            出版日Label.Location = new System.Drawing.Point(84, 115);
            出版日Label.Name = "出版日Label";
            出版日Label.Size = new System.Drawing.Size(56, 15);
            出版日Label.TabIndex = 21;
            出版日Label.Text = "出版日:";
            // 
            // 出版日DateTimePicker
            // 
            this.出版日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.書籍資料BindingSource, "出版日", true));
            this.出版日DateTimePicker.Location = new System.Drawing.Point(146, 111);
            this.出版日DateTimePicker.Name = "出版日DateTimePicker";
            this.出版日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.出版日DateTimePicker.TabIndex = 22;
            // 
            // 定價Label
            // 
            定價Label.AutoSize = true;
            定價Label.Location = new System.Drawing.Point(84, 145);
            定價Label.Name = "定價Label";
            定價Label.Size = new System.Drawing.Size(41, 15);
            定價Label.TabIndex = 23;
            定價Label.Text = "定價:";
            // 
            // 定價TextBox
            // 
            this.定價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.書籍資料BindingSource, "定價", true));
            this.定價TextBox.Location = new System.Drawing.Point(146, 142);
            this.定價TextBox.Name = "定價TextBox";
            this.定價TextBox.Size = new System.Drawing.Size(200, 25);
            this.定價TextBox.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(351, 280);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 28);
            this.button8.TabIndex = 25;
            this.button8.Text = "結束";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 365);
            this.Controls.Add(this.button8);
            this.Controls.Add(書號Label);
            this.Controls.Add(this.書號TextBox);
            this.Controls.Add(書名Label);
            this.Controls.Add(this.書名TextBox);
            this.Controls.Add(出版日Label);
            this.Controls.Add(this.出版日DateTimePicker);
            this.Controls.Add(定價Label);
            this.Controls.Add(this.定價TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "按鈕版";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._p11_1dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.書籍資料BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private _p11_1dbDataSet _p11_1dbDataSet;
        private System.Windows.Forms.BindingSource 書籍BindingSource;
        private _p11_1dbDataSetTableAdapters.書籍TableAdapter 書籍TableAdapter;
        private System.Windows.Forms.BindingSource 書籍BindingSource1;
        private _p11_1dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private testdbDataSet testdbDataSet;
        private testdbDataSetTableAdapters.書籍資料TableAdapter 書籍資料TableAdapter1;
        private System.Windows.Forms.BindingSource 書籍資料BindingSource;
        private testdbDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox 書號TextBox;
        private System.Windows.Forms.TextBox 書名TextBox;
        private System.Windows.Forms.DateTimePicker 出版日DateTimePicker;
        private System.Windows.Forms.TextBox 定價TextBox;
        private System.Windows.Forms.Button button8;
    }
}