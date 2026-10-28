#nullable disable
namespace Contacts.WinForms;

partial class FormContacts
{
    private System.ComponentModel.IContainer components = null;

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
        label1 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        lNom = new Label();
        tbNom = new TextBox();
        tbCourriel = new TextBox();
        lCourriel = new Label();
        bCreer = new Button();
        bEffacer = new Button();
        flowLayoutPanel1 = new FlowLayoutPanel();
        lEtat = new Label();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.BackColor = SystemColors.Control;
        label1.Font = new Font("Segoe UI", 16F);
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(776, 37);
        label1.TabIndex = 1;
        label1.Text = "Contacts - maquette E1";
        label1.Click += label1_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.84884F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.15116F));
        tableLayoutPanel1.Controls.Add(lNom, 0, 0);
        tableLayoutPanel1.Controls.Add(tbNom, 1, 0);
        tableLayoutPanel1.Controls.Add(tbCourriel, 1, 1);
        tableLayoutPanel1.Controls.Add(lCourriel, 0, 1);
        tableLayoutPanel1.Controls.Add(bCreer, 1, 2);
        tableLayoutPanel1.Controls.Add(bEffacer, 2, 2);
        tableLayoutPanel1.Location = new Point(3, 40);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.1372566F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.8627434F));
        tableLayoutPanel1.Size = new Size(776, 125);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // lNom
        // 
        lNom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lNom.AutoSize = true;
        lNom.Location = new Point(3, 0);
        lNom.Name = "lNom";
        lNom.Size = new Size(42, 49);
        lNom.TabIndex = 0;
        lNom.Text = "&Nom";
        lNom.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tbNom
        // 
        tbNom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(tbNom, 2);
        tbNom.Location = new Point(217, 3);
        tbNom.Name = "tbNom";
        tbNom.Size = new Size(556, 27);
        tbNom.TabIndex = 0;
        // 
        // tbCourriel
        // 
        tbCourriel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(tbCourriel, 2);
        tbCourriel.Location = new Point(217, 52);
        tbCourriel.Name = "tbCourriel";
        tbCourriel.Size = new Size(556, 27);
        tbCourriel.TabIndex = 1;
        tbCourriel.TextChanged += textBox2_TextChanged;
        // 
        // lCourriel
        // 
        lCourriel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lCourriel.AutoSize = true;
        lCourriel.Location = new Point(3, 49);
        lCourriel.Name = "lCourriel";
        lCourriel.Size = new Size(61, 32);
        lCourriel.TabIndex = 1;
        lCourriel.Text = "C&ourriel";
        lCourriel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bCreer
        // 
        bCreer.AutoSize = true;
        bCreer.Location = new Point(217, 84);
        bCreer.Name = "bCreer";
        bCreer.Size = new Size(109, 30);
        bCreer.TabIndex = 2;
        bCreer.Text = "&Créer";
        bCreer.UseVisualStyleBackColor = true;
        bCreer.Click += bCreer_Click;
        // 
        // bEffacer
        // 
        bEffacer.AutoSize = true;
        bEffacer.Location = new Point(340, 84);
        bEffacer.Name = "bEffacer";
        bEffacer.Size = new Size(131, 30);
        bEffacer.TabIndex = 3;
        bEffacer.Text = "&Effacer";
        bEffacer.UseVisualStyleBackColor = true;
        bEffacer.Click += bEffacer_Click;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(label1);
        flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
        flowLayoutPanel1.Controls.Add(lEtat);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(782, 548);
        flowLayoutPanel1.TabIndex = 6;
        flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
        // 
        // lEtat
        // 
        lEtat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lEtat.Location = new Point(3, 168);
        lEtat.Name = "lEtat";
        lEtat.Size = new Size(776, 20);
        lEtat.TabIndex = 4;
        lEtat.Text = "État de l'opération -- IEtat";
        lEtat.Click += label2_Click;
        // 
        // FormContacts
        // 
        AcceptButton = bCreer;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 548);
        Controls.Add(flowLayoutPanel1);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(797, 584);
        Name = "FormContacts";
        Text = "Fiche de contact — à construire";
        Load += FormContacts_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        // Construire les contrôles dans le designer et relier chaque Click une seule fois.
    }
    private Label label1;
    private TableLayoutPanel tableLayoutPanel1;
    private Label lNom;
    private Label lCourriel;
    private TextBox tbNom;
    private TextBox tbCourriel;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button bCreer;
    private Button bEffacer;
    private Label lEtat;
}
