namespace DesktopList
{
    partial class FormDesktopList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListBoxDisplayAllDesktopItems = new ListBox();
            RefKeyword = new TextBox();
            ButtonSearch = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SearchByFun = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ListBoxDisplayAllDesktopItems
            // 
            ListBoxDisplayAllDesktopItems.FormattingEnabled = true;
            ListBoxDisplayAllDesktopItems.ItemHeight = 15;
            ListBoxDisplayAllDesktopItems.Location = new Point(23, 23);
            ListBoxDisplayAllDesktopItems.Name = "ListBoxDisplayAllDesktopItems";
            ListBoxDisplayAllDesktopItems.Size = new Size(120, 169);
            ListBoxDisplayAllDesktopItems.TabIndex = 0;
            // 
            // RefKeyword
            // 
            RefKeyword.Location = new Point(191, 50);
            RefKeyword.Name = "RefKeyword";
            RefKeyword.Size = new Size(100, 23);
            RefKeyword.TabIndex = 1;
            RefKeyword.TextChanged += RefKeyword_TextChanged;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(191, 90);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(75, 23);
            ButtonSearch.TabIndex = 2;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // SearchByFun
            // 
            SearchByFun.Location = new Point(191, 128);
            SearchByFun.Name = "SearchByFun";
            SearchByFun.Size = new Size(75, 53);
            SearchByFun.TabIndex = 3;
            SearchByFun.Text = "Search By Function";
            SearchByFun.UseVisualStyleBackColor = true;
            SearchByFun.Click += SearchByFun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 23);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter keyword to search:";
            // 
            // FormDesktopList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 450);
            Controls.Add(label1);
            Controls.Add(SearchByFun);
            Controls.Add(ButtonSearch);
            Controls.Add(RefKeyword);
            Controls.Add(ListBoxDisplayAllDesktopItems);
            Name = "FormDesktopList";
            Text = "Desktop List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxDisplayAllDesktopItems;
        private TextBox RefKeyword;
        private Button ButtonSearch;
        private ContextMenuStrip contextMenuStrip1;
        private Button SearchByFun;
        private Label label1;
    }
}
