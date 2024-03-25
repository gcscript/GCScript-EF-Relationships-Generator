namespace GCScript_EF_Relationships_Generator
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            txt_Entity1 = new TextBox();
            txt_Entity2 = new TextBox();
            cmb_Relationship = new ComboBox();
            btn_ReverseRelationship = new Button();
            rtxt_Model1 = new RichTextBox();
            rtxt_FluentApi = new RichTextBox();
            lbl_Relationship = new Label();
            lbl_Entity1 = new Label();
            lbl_Entity2 = new Label();
            lbl_Explanation = new Label();
            btn_CopyFluentApi = new Button();
            chk_IsRequired = new CheckBox();
            cmb_EntityArticle2 = new ComboBox();
            cmb_EntityVerb1 = new ComboBox();
            cmb_EntityVerb2 = new ComboBox();
            cmb_EntityPronouns2 = new ComboBox();
            chk_AutoArticleAndVerb = new CheckBox();
            label1 = new Label();
            cmb_EntityArticle1 = new ComboBox();
            rtxt_Model2 = new RichTextBox();
            btn_CopyModel1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            chk_Comments = new CheckBox();
            chk_Nullable = new CheckBox();
            btn_CopyModel2 = new Button();
            cmb_IdType = new ComboBox();
            label3 = new Label();
            tbc_Main = new TabControl();
            tbp_Models = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tbp_FluentApi = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbp_Context = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            rtxt_Context = new RichTextBox();
            btn_CopyContext = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            tbc_Main.SuspendLayout();
            tbp_Models.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tbp_FluentApi.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbp_Context.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Entity1
            // 
            txt_Entity1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel3.SetColumnSpan(txt_Entity1, 4);
            txt_Entity1.Dock = DockStyle.Fill;
            txt_Entity1.Location = new Point(1, 73);
            txt_Entity1.Margin = new Padding(1);
            txt_Entity1.MaxLength = 100;
            txt_Entity1.Name = "txt_Entity1";
            txt_Entity1.Size = new Size(326, 25);
            txt_Entity1.TabIndex = 3;
            txt_Entity1.TextChanged += txt_Entity1_TextChanged;
            // 
            // txt_Entity2
            // 
            txt_Entity2.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel3.SetColumnSpan(txt_Entity2, 4);
            txt_Entity2.Dock = DockStyle.Fill;
            txt_Entity2.Location = new Point(429, 73);
            txt_Entity2.Margin = new Padding(1);
            txt_Entity2.MaxLength = 100;
            txt_Entity2.Name = "txt_Entity2";
            txt_Entity2.Size = new Size(326, 25);
            txt_Entity2.TabIndex = 5;
            txt_Entity2.TextChanged += txt_Entity2_TextChanged;
            // 
            // cmb_Relationship
            // 
            tableLayoutPanel3.SetColumnSpan(cmb_Relationship, 4);
            cmb_Relationship.Dock = DockStyle.Fill;
            cmb_Relationship.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Relationship.FormattingEnabled = true;
            cmb_Relationship.Location = new Point(1, 23);
            cmb_Relationship.Margin = new Padding(1);
            cmb_Relationship.Name = "cmb_Relationship";
            cmb_Relationship.Size = new Size(326, 26);
            cmb_Relationship.TabIndex = 0;
            cmb_Relationship.SelectedIndexChanged += cmb_Relationship_SelectedIndexChanged;
            // 
            // btn_ReverseRelationship
            // 
            btn_ReverseRelationship.BackColor = Color.FromArgb(126, 111, 255);
            btn_ReverseRelationship.Dock = DockStyle.Fill;
            btn_ReverseRelationship.FlatStyle = FlatStyle.Flat;
            btn_ReverseRelationship.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ReverseRelationship.ForeColor = Color.White;
            btn_ReverseRelationship.Location = new Point(329, 73);
            btn_ReverseRelationship.Margin = new Padding(1);
            btn_ReverseRelationship.Name = "btn_ReverseRelationship";
            btn_ReverseRelationship.Size = new Size(98, 25);
            btn_ReverseRelationship.TabIndex = 4;
            btn_ReverseRelationship.TabStop = false;
            btn_ReverseRelationship.Text = "Reverse";
            btn_ReverseRelationship.UseVisualStyleBackColor = false;
            btn_ReverseRelationship.Click += btn_ReverseRelationship_Click;
            // 
            // rtxt_Model1
            // 
            rtxt_Model1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel7.SetColumnSpan(rtxt_Model1, 3);
            rtxt_Model1.Dock = DockStyle.Fill;
            rtxt_Model1.Location = new Point(1, 27);
            rtxt_Model1.Margin = new Padding(1);
            rtxt_Model1.MaxLength = 1000;
            rtxt_Model1.Name = "rtxt_Model1";
            rtxt_Model1.ReadOnly = true;
            rtxt_Model1.Size = new Size(752, 190);
            rtxt_Model1.TabIndex = 7;
            rtxt_Model1.TabStop = false;
            rtxt_Model1.Text = "";
            // 
            // rtxt_FluentApi
            // 
            rtxt_FluentApi.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(rtxt_FluentApi, 3);
            rtxt_FluentApi.Dock = DockStyle.Fill;
            rtxt_FluentApi.Location = new Point(1, 1);
            rtxt_FluentApi.Margin = new Padding(1);
            rtxt_FluentApi.MaxLength = 1000;
            rtxt_FluentApi.Name = "rtxt_FluentApi";
            rtxt_FluentApi.ReadOnly = true;
            rtxt_FluentApi.Size = new Size(752, 454);
            rtxt_FluentApi.TabIndex = 9;
            rtxt_FluentApi.TabStop = false;
            rtxt_FluentApi.Text = "";
            // 
            // lbl_Relationship
            // 
            lbl_Relationship.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(lbl_Relationship, 4);
            lbl_Relationship.Dock = DockStyle.Fill;
            lbl_Relationship.Location = new Point(1, 3);
            lbl_Relationship.Margin = new Padding(1, 3, 1, 1);
            lbl_Relationship.Name = "lbl_Relationship";
            lbl_Relationship.Size = new Size(326, 18);
            lbl_Relationship.TabIndex = 10;
            lbl_Relationship.Text = "Relationship";
            // 
            // lbl_Entity1
            // 
            lbl_Entity1.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(lbl_Entity1, 4);
            lbl_Entity1.Dock = DockStyle.Fill;
            lbl_Entity1.Location = new Point(1, 53);
            lbl_Entity1.Margin = new Padding(1, 3, 1, 1);
            lbl_Entity1.Name = "lbl_Entity1";
            lbl_Entity1.Size = new Size(326, 18);
            lbl_Entity1.TabIndex = 12;
            lbl_Entity1.Text = "Entity 1";
            // 
            // lbl_Entity2
            // 
            lbl_Entity2.AutoSize = true;
            tableLayoutPanel3.SetColumnSpan(lbl_Entity2, 4);
            lbl_Entity2.Dock = DockStyle.Fill;
            lbl_Entity2.Location = new Point(429, 53);
            lbl_Entity2.Margin = new Padding(1, 3, 1, 1);
            lbl_Entity2.Name = "lbl_Entity2";
            lbl_Entity2.Size = new Size(326, 18);
            lbl_Entity2.TabIndex = 13;
            lbl_Entity2.Text = "Entity 2";
            // 
            // lbl_Explanation
            // 
            lbl_Explanation.AutoSize = true;
            lbl_Explanation.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel6.SetColumnSpan(lbl_Explanation, 7);
            lbl_Explanation.Dock = DockStyle.Fill;
            lbl_Explanation.FlatStyle = FlatStyle.Flat;
            lbl_Explanation.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Explanation.ForeColor = Color.FromArgb(126, 111, 255);
            lbl_Explanation.Location = new Point(0, 28);
            lbl_Explanation.Margin = new Padding(0);
            lbl_Explanation.Name = "lbl_Explanation";
            lbl_Explanation.Padding = new Padding(5);
            lbl_Explanation.Size = new Size(754, 69);
            lbl_Explanation.TabIndex = 16;
            lbl_Explanation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_CopyFluentApi
            // 
            btn_CopyFluentApi.AutoSize = true;
            btn_CopyFluentApi.BackColor = Color.FromArgb(126, 111, 255);
            btn_CopyFluentApi.Dock = DockStyle.Fill;
            btn_CopyFluentApi.FlatStyle = FlatStyle.Flat;
            btn_CopyFluentApi.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CopyFluentApi.ForeColor = Color.White;
            btn_CopyFluentApi.Location = new Point(655, 457);
            btn_CopyFluentApi.Margin = new Padding(1);
            btn_CopyFluentApi.Name = "btn_CopyFluentApi";
            btn_CopyFluentApi.Size = new Size(98, 28);
            btn_CopyFluentApi.TabIndex = 8;
            btn_CopyFluentApi.Text = "Copy";
            btn_CopyFluentApi.UseVisualStyleBackColor = false;
            btn_CopyFluentApi.Click += btn_CopyFluentApi_Click;
            // 
            // chk_IsRequired
            // 
            chk_IsRequired.Anchor = AnchorStyles.Right;
            chk_IsRequired.AutoSize = true;
            chk_IsRequired.Location = new Point(543, 460);
            chk_IsRequired.Margin = new Padding(1);
            chk_IsRequired.Name = "chk_IsRequired";
            chk_IsRequired.Size = new Size(110, 22);
            chk_IsRequired.TabIndex = 2;
            chk_IsRequired.Text = "IsRequired";
            chk_IsRequired.UseVisualStyleBackColor = true;
            chk_IsRequired.CheckedChanged += chk_IsRequired_CheckedChanged;
            // 
            // cmb_EntityArticle2
            // 
            cmb_EntityArticle2.Dock = DockStyle.Fill;
            cmb_EntityArticle2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EntityArticle2.FormattingEnabled = true;
            cmb_EntityArticle2.Location = new Point(301, 1);
            cmb_EntityArticle2.Margin = new Padding(1);
            cmb_EntityArticle2.Name = "cmb_EntityArticle2";
            cmb_EntityArticle2.Size = new Size(98, 26);
            cmb_EntityArticle2.TabIndex = 17;
            cmb_EntityArticle2.SelectedIndexChanged += cmb_EntityArticle2_SelectedIndexChanged;
            // 
            // cmb_EntityVerb1
            // 
            cmb_EntityVerb1.Dock = DockStyle.Fill;
            cmb_EntityVerb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EntityVerb1.FormattingEnabled = true;
            cmb_EntityVerb1.Location = new Point(101, 1);
            cmb_EntityVerb1.Margin = new Padding(1);
            cmb_EntityVerb1.Name = "cmb_EntityVerb1";
            cmb_EntityVerb1.Size = new Size(98, 26);
            cmb_EntityVerb1.TabIndex = 17;
            cmb_EntityVerb1.SelectedIndexChanged += cmb_EntityVerb1_SelectedIndexChanged;
            // 
            // cmb_EntityVerb2
            // 
            cmb_EntityVerb2.Dock = DockStyle.Fill;
            cmb_EntityVerb2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EntityVerb2.FormattingEnabled = true;
            cmb_EntityVerb2.Location = new Point(401, 1);
            cmb_EntityVerb2.Margin = new Padding(1);
            cmb_EntityVerb2.Name = "cmb_EntityVerb2";
            cmb_EntityVerb2.Size = new Size(98, 26);
            cmb_EntityVerb2.TabIndex = 17;
            cmb_EntityVerb2.SelectedIndexChanged += cmb_EntityVerb2_SelectedIndexChanged;
            // 
            // cmb_EntityPronouns2
            // 
            cmb_EntityPronouns2.Dock = DockStyle.Fill;
            cmb_EntityPronouns2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EntityPronouns2.FormattingEnabled = true;
            cmb_EntityPronouns2.Location = new Point(201, 1);
            cmb_EntityPronouns2.Margin = new Padding(1);
            cmb_EntityPronouns2.Name = "cmb_EntityPronouns2";
            cmb_EntityPronouns2.Size = new Size(98, 26);
            cmb_EntityPronouns2.TabIndex = 17;
            cmb_EntityPronouns2.SelectedIndexChanged += cmb_EntityPronouns2_SelectedIndexChanged;
            // 
            // chk_AutoArticleAndVerb
            // 
            chk_AutoArticleAndVerb.Anchor = AnchorStyles.Right;
            chk_AutoArticleAndVerb.AutoSize = true;
            chk_AutoArticleAndVerb.Location = new Point(691, 1);
            chk_AutoArticleAndVerb.Margin = new Padding(1);
            chk_AutoArticleAndVerb.Name = "chk_AutoArticleAndVerb";
            chk_AutoArticleAndVerb.Padding = new Padding(0, 3, 0, 0);
            chk_AutoArticleAndVerb.Size = new Size(62, 25);
            chk_AutoArticleAndVerb.TabIndex = 17;
            chk_AutoArticleAndVerb.Text = "Auto";
            chk_AutoArticleAndVerb.UseVisualStyleBackColor = true;
            chk_AutoArticleAndVerb.CheckedChanged += chk_AutoArticleAndVerb_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label1.Location = new Point(1, 1);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(298, 24);
            label1.TabIndex = 14;
            label1.Text = "Entity 1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_EntityArticle1
            // 
            cmb_EntityArticle1.Dock = DockStyle.Fill;
            cmb_EntityArticle1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_EntityArticle1.FormattingEnabled = true;
            cmb_EntityArticle1.Location = new Point(1, 1);
            cmb_EntityArticle1.Margin = new Padding(1);
            cmb_EntityArticle1.Name = "cmb_EntityArticle1";
            cmb_EntityArticle1.Size = new Size(98, 26);
            cmb_EntityArticle1.TabIndex = 17;
            cmb_EntityArticle1.SelectedIndexChanged += cmb_EntityArticle1_SelectedIndexChanged;
            // 
            // rtxt_Model2
            // 
            rtxt_Model2.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel10.SetColumnSpan(rtxt_Model2, 3);
            rtxt_Model2.Dock = DockStyle.Fill;
            rtxt_Model2.Location = new Point(1, 27);
            rtxt_Model2.Margin = new Padding(1);
            rtxt_Model2.MaxLength = 1000;
            rtxt_Model2.Name = "rtxt_Model2";
            rtxt_Model2.ReadOnly = true;
            rtxt_Model2.Size = new Size(752, 190);
            rtxt_Model2.TabIndex = 7;
            rtxt_Model2.TabStop = false;
            rtxt_Model2.Text = "";
            // 
            // btn_CopyModel1
            // 
            btn_CopyModel1.BackColor = Color.FromArgb(126, 111, 255);
            btn_CopyModel1.Dock = DockStyle.Fill;
            btn_CopyModel1.FlatStyle = FlatStyle.Flat;
            btn_CopyModel1.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CopyModel1.ForeColor = Color.White;
            btn_CopyModel1.Location = new Point(655, 219);
            btn_CopyModel1.Margin = new Padding(1);
            btn_CopyModel1.Name = "btn_CopyModel1";
            btn_CopyModel1.Size = new Size(98, 28);
            btn_CopyModel1.TabIndex = 6;
            btn_CopyModel1.Text = "Copy";
            btn_CopyModel1.UseVisualStyleBackColor = false;
            btn_CopyModel1.Click += btn_CopyModel1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            tableLayoutPanel7.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(chk_Comments);
            flowLayoutPanel1.Controls.Add(chk_Nullable);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(301, 1);
            flowLayoutPanel1.Margin = new Padding(1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(452, 24);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // chk_Comments
            // 
            chk_Comments.AutoSize = true;
            chk_Comments.Location = new Point(357, 1);
            chk_Comments.Margin = new Padding(1);
            chk_Comments.Name = "chk_Comments";
            chk_Comments.Size = new Size(94, 22);
            chk_Comments.TabIndex = 3;
            chk_Comments.Text = "Comments";
            chk_Comments.UseVisualStyleBackColor = true;
            chk_Comments.CheckedChanged += chk_Comments_CheckedChanged;
            // 
            // chk_Nullable
            // 
            chk_Nullable.AutoSize = true;
            chk_Nullable.Location = new Point(261, 1);
            chk_Nullable.Margin = new Padding(1);
            chk_Nullable.Name = "chk_Nullable";
            chk_Nullable.Size = new Size(94, 22);
            chk_Nullable.TabIndex = 4;
            chk_Nullable.Text = "Nullable";
            chk_Nullable.UseVisualStyleBackColor = true;
            chk_Nullable.CheckedChanged += chk_Nullable_CheckedChanged;
            // 
            // btn_CopyModel2
            // 
            btn_CopyModel2.BackColor = Color.FromArgb(126, 111, 255);
            btn_CopyModel2.Dock = DockStyle.Fill;
            btn_CopyModel2.FlatStyle = FlatStyle.Flat;
            btn_CopyModel2.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CopyModel2.ForeColor = Color.White;
            btn_CopyModel2.Location = new Point(655, 219);
            btn_CopyModel2.Margin = new Padding(1);
            btn_CopyModel2.Name = "btn_CopyModel2";
            btn_CopyModel2.Size = new Size(98, 28);
            btn_CopyModel2.TabIndex = 6;
            btn_CopyModel2.Text = "Copy";
            btn_CopyModel2.UseVisualStyleBackColor = false;
            btn_CopyModel2.Click += btn_CopyModel2_Click;
            // 
            // cmb_IdType
            // 
            cmb_IdType.Dock = DockStyle.Fill;
            cmb_IdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdType.FormattingEnabled = true;
            cmb_IdType.Location = new Point(329, 23);
            cmb_IdType.Margin = new Padding(1);
            cmb_IdType.Name = "cmb_IdType";
            cmb_IdType.Size = new Size(98, 26);
            cmb_IdType.TabIndex = 1;
            cmb_IdType.SelectedIndexChanged += cmb_IdType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(329, 3);
            label3.Margin = new Padding(1, 3, 1, 1);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 11;
            label3.Text = "Id Type";
            // 
            // tbc_Main
            // 
            tbc_Main.Controls.Add(tbp_Models);
            tbc_Main.Controls.Add(tbp_FluentApi);
            tbc_Main.Controls.Add(tbp_Context);
            tbc_Main.Dock = DockStyle.Fill;
            tbc_Main.Location = new Point(10, 125);
            tbc_Main.Margin = new Padding(0, 10, 0, 0);
            tbc_Main.Name = "tbc_Main";
            tbc_Main.SelectedIndex = 0;
            tbc_Main.Size = new Size(762, 627);
            tbc_Main.TabIndex = 1;
            // 
            // tbp_Models
            // 
            tbp_Models.Controls.Add(tableLayoutPanel4);
            tbp_Models.Location = new Point(4, 27);
            tbp_Models.Name = "tbp_Models";
            tbp_Models.Size = new Size(754, 596);
            tbp_Models.TabIndex = 0;
            tbp_Models.Text = "Models";
            tbp_Models.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(754, 596);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.AutoSize = true;
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel10.Controls.Add(btn_CopyModel2, 2, 2);
            tableLayoutPanel10.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel10.Controls.Add(rtxt_Model2, 0, 1);
            tableLayoutPanel10.Controls.Add(label4, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 348);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel10.Size = new Size(754, 248);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            tableLayoutPanel10.SetColumnSpan(flowLayoutPanel2, 2);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(301, 1);
            flowLayoutPanel2.Margin = new Padding(1);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(452, 24);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label4.Location = new Point(1, 1);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(298, 24);
            label4.TabIndex = 14;
            label4.Text = "Entity 2";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 7;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(chk_AutoArticleAndVerb, 6, 0);
            tableLayoutPanel6.Controls.Add(lbl_Explanation, 0, 1);
            tableLayoutPanel6.Controls.Add(cmb_EntityArticle1, 0, 0);
            tableLayoutPanel6.Controls.Add(cmb_EntityVerb1, 1, 0);
            tableLayoutPanel6.Controls.Add(cmb_EntityPronouns2, 2, 0);
            tableLayoutPanel6.Controls.Add(cmb_EntityArticle2, 3, 0);
            tableLayoutPanel6.Controls.Add(cmb_EntityVerb2, 4, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0, 0, 0, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(754, 97);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel7.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel7.Controls.Add(rtxt_Model1, 0, 1);
            tableLayoutPanel7.Controls.Add(btn_CopyModel1, 2, 2);
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 100);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel7.Size = new Size(754, 248);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tbp_FluentApi
            // 
            tbp_FluentApi.Controls.Add(tableLayoutPanel1);
            tbp_FluentApi.Location = new Point(4, 29);
            tbp_FluentApi.Name = "tbp_FluentApi";
            tbp_FluentApi.Size = new Size(754, 486);
            tbp_FluentApi.TabIndex = 1;
            tbp_FluentApi.Text = "Fluent API";
            tbp_FluentApi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(rtxt_FluentApi, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_CopyFluentApi, 2, 1);
            tableLayoutPanel1.Controls.Add(chk_IsRequired, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(754, 486);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // tbp_Context
            // 
            tbp_Context.Controls.Add(tableLayoutPanel8);
            tbp_Context.Location = new Point(4, 29);
            tbp_Context.Name = "tbp_Context";
            tbp_Context.Size = new Size(754, 486);
            tbp_Context.TabIndex = 2;
            tbp_Context.Text = "Context";
            tbp_Context.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel8.Controls.Add(rtxt_Context, 0, 0);
            tableLayoutPanel8.Controls.Add(btn_CopyContext, 2, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel8.Size = new Size(754, 486);
            tableLayoutPanel8.TabIndex = 17;
            // 
            // rtxt_Context
            // 
            rtxt_Context.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel8.SetColumnSpan(rtxt_Context, 3);
            rtxt_Context.Dock = DockStyle.Fill;
            rtxt_Context.Location = new Point(1, 1);
            rtxt_Context.Margin = new Padding(1);
            rtxt_Context.MaxLength = 1000;
            rtxt_Context.Name = "rtxt_Context";
            rtxt_Context.ReadOnly = true;
            rtxt_Context.Size = new Size(752, 454);
            rtxt_Context.TabIndex = 9;
            rtxt_Context.TabStop = false;
            rtxt_Context.Text = "";
            // 
            // btn_CopyContext
            // 
            btn_CopyContext.AutoSize = true;
            btn_CopyContext.BackColor = Color.FromArgb(126, 111, 255);
            btn_CopyContext.Dock = DockStyle.Fill;
            btn_CopyContext.FlatStyle = FlatStyle.Flat;
            btn_CopyContext.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CopyContext.ForeColor = Color.White;
            btn_CopyContext.Location = new Point(655, 457);
            btn_CopyContext.Margin = new Padding(1);
            btn_CopyContext.Name = "btn_CopyContext";
            btn_CopyContext.Size = new Size(98, 28);
            btn_CopyContext.TabIndex = 8;
            btn_CopyContext.Text = "Copy";
            btn_CopyContext.UseVisualStyleBackColor = false;
            btn_CopyContext.Click += btn_CopyContext_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tbc_Main, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10, 10, 10, 1);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(782, 753);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 9;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.Controls.Add(lbl_Relationship, 0, 0);
            tableLayoutPanel3.Controls.Add(txt_Entity2, 5, 3);
            tableLayoutPanel3.Controls.Add(lbl_Entity2, 5, 2);
            tableLayoutPanel3.Controls.Add(btn_ReverseRelationship, 4, 3);
            tableLayoutPanel3.Controls.Add(txt_Entity1, 0, 3);
            tableLayoutPanel3.Controls.Add(lbl_Entity1, 0, 2);
            tableLayoutPanel3.Controls.Add(cmb_Relationship, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 4, 0);
            tableLayoutPanel3.Controls.Add(cmb_IdType, 4, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(13, 13);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(756, 99);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 800);
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCScript EF Relationships Generator";
            Load += frm_Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tbc_Main.ResumeLayout(false);
            tbp_Models.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tbp_FluentApi.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tbp_Context.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Entity1;
        private TextBox txt_Entity2;
        private ComboBox cmb_Relationship;
        private Button btn_ReverseRelationship;
        private TextBox txt_Result;
        private RichTextBox rtxt_Model1;
        private RichTextBox rtxt_FluentApi;
        private Label lbl_Relationship;
        private Label lbl_Entity1;
        private Label lbl_Entity2;
        private Label label1;
        private Label lbl_Explanation;
        private Button btn_CopyModel1;
        private Button btn_CopyFluentApi;
        private ComboBox cmb_IdType;
        private Label label3;
        private CheckBox chk_IsRequired;
        private ComboBox cmb_EntityArticle1;
        private ComboBox cmb_EntityArticle2;
        private ComboBox cmb_EntityVerb1;
        private ComboBox cmb_EntityVerb2;
        private ComboBox cmb_EntityPronouns2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox chk_Comments;
        private CheckBox chk_Nullable;
        private CheckBox chk_AutoArticleAndVerb;
        private RichTextBox rtxt_Model2;
        private Button btn_CopyModel2;
        private TabControl tbc_Main;
        private TabPage tbp_Models;
        private TabPage tbp_FluentApi;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tbp_Context;
        private TableLayoutPanel tableLayoutPanel8;
        private RichTextBox rtxt_Context;
        private Button btn_CopyContext;
        private TableLayoutPanel tableLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
    }
}
