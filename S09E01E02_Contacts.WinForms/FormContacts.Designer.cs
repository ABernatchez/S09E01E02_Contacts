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
        tableLayoutRoot = new TableLayoutPanel();
        lTitle = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        lNom = new Label();
        tbNom = new TextBox();
        lCourriel = new Label();
        lMotClef = new Label();
        tbCourriel = new TextBox();
        bCreer = new Button();
        bEffacer = new Button();
        tableLayoutPanelMotClef = new TableLayoutPanel();
        tbMotClef = new TextBox();
        bRechercher = new Button();
        bTous = new Button();
        dgvContacts = new DataGridView();
        dgvContactsColumnNom = new DataGridViewTextBoxColumn();
        dgvContactsColumnCourriel = new DataGridViewTextBoxColumn();
        lNombre = new Label();
        lEtat = new Label();
        tableLayoutRoot.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanelMotClef.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutRoot
        // 
        tableLayoutRoot.ColumnCount = 1;
        tableLayoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutRoot.Controls.Add(lTitle, 0, 0);
        tableLayoutRoot.Controls.Add(tableLayoutPanel1, 0, 1);
        tableLayoutRoot.Controls.Add(dgvContacts, 0, 2);
        tableLayoutRoot.Controls.Add(lNombre, 0, 3);
        tableLayoutRoot.Controls.Add(lEtat, 0, 4);
        tableLayoutRoot.Dock = DockStyle.Fill;
        tableLayoutRoot.Location = new Point(0, 0);
        tableLayoutRoot.Name = "tableLayoutRoot";
        tableLayoutRoot.RowCount = 5;
        tableLayoutRoot.RowStyles.Add(new RowStyle());
        tableLayoutRoot.RowStyles.Add(new RowStyle());
        tableLayoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutRoot.RowStyles.Add(new RowStyle());
        tableLayoutRoot.RowStyles.Add(new RowStyle());
        tableLayoutRoot.Size = new Size(782, 548);
        tableLayoutRoot.TabIndex = 0;
        // 
        // lTitle
        // 
        lTitle.AutoSize = true;
        lTitle.BackColor = SystemColors.Control;
        lTitle.Dock = DockStyle.Fill;
        lTitle.Font = new Font("Segoe UI", 16F);
        lTitle.Location = new Point(3, 0);
        lTitle.Name = "lTitle";
        lTitle.Size = new Size(776, 37);
        lTitle.TabIndex = 1;
        lTitle.Text = "Contacts - maquette E1";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(lNom, 0, 0);
        tableLayoutPanel1.Controls.Add(tbNom, 1, 0);
        tableLayoutPanel1.Controls.Add(lCourriel, 0, 1);
        tableLayoutPanel1.Controls.Add(lMotClef, 0, 3);
        tableLayoutPanel1.Controls.Add(tbCourriel, 1, 1);
        tableLayoutPanel1.Controls.Add(bCreer, 1, 2);
        tableLayoutPanel1.Controls.Add(bEffacer, 2, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanelMotClef, 1, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(3, 40);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(776, 138);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // lNom
        // 
        lNom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lNom.AutoSize = true;
        lNom.Location = new Point(3, 0);
        lNom.Name = "lNom";
        lNom.Size = new Size(42, 33);
        lNom.TabIndex = 0;
        lNom.Text = "&Nom";
        lNom.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tbNom
        // 
        tbNom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(tbNom, 2);
        tbNom.Location = new Point(203, 3);
        tbNom.Name = "tbNom";
        tbNom.Size = new Size(570, 27);
        tbNom.TabIndex = 0;
        // 
        // lCourriel
        // 
        lCourriel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lCourriel.AutoSize = true;
        lCourriel.Location = new Point(3, 33);
        lCourriel.Name = "lCourriel";
        lCourriel.Size = new Size(61, 33);
        lCourriel.TabIndex = 1;
        lCourriel.Text = "C&ourriel";
        lCourriel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lMotClef
        // 
        lMotClef.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        lMotClef.Location = new Point(3, 102);
        lMotClef.Name = "lMotClef";
        lMotClef.Size = new Size(66, 36);
        lMotClef.TabIndex = 4;
        lMotClef.Text = "Mot-clef";
        lMotClef.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tbCourriel
        // 
        tbCourriel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.SetColumnSpan(tbCourriel, 2);
        tbCourriel.Location = new Point(203, 36);
        tbCourriel.Name = "tbCourriel";
        tbCourriel.Size = new Size(570, 27);
        tbCourriel.TabIndex = 1;
        // 
        // bCreer
        // 
        bCreer.AutoSize = true;
        bCreer.Location = new Point(203, 69);
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
        bEffacer.Location = new Point(318, 69);
        bEffacer.Name = "bEffacer";
        bEffacer.Size = new Size(131, 30);
        bEffacer.TabIndex = 3;
        bEffacer.Text = "&Effacer";
        bEffacer.UseVisualStyleBackColor = true;
        bEffacer.Click += bEffacer_Click;
        // 
        // tableLayoutPanelMotClef
        // 
        tableLayoutPanelMotClef.AutoSize = true;
        tableLayoutPanelMotClef.ColumnCount = 3;
        tableLayoutPanel1.SetColumnSpan(tableLayoutPanelMotClef, 2);
        tableLayoutPanelMotClef.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelMotClef.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelMotClef.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelMotClef.Controls.Add(tbMotClef, 0, 0);
        tableLayoutPanelMotClef.Controls.Add(bRechercher, 1, 0);
        tableLayoutPanelMotClef.Controls.Add(bTous, 2, 0);
        tableLayoutPanelMotClef.Dock = DockStyle.Fill;
        tableLayoutPanelMotClef.Location = new Point(200, 102);
        tableLayoutPanelMotClef.Margin = new Padding(0);
        tableLayoutPanelMotClef.Name = "tableLayoutPanelMotClef";
        tableLayoutPanelMotClef.RowCount = 1;
        tableLayoutPanelMotClef.RowStyles.Add(new RowStyle());
        tableLayoutPanelMotClef.Size = new Size(576, 36);
        // 
        // tbMotClef
        // 
        tbMotClef.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tbMotClef.Location = new Point(3, 3);
        tbMotClef.Name = "tbMotClef";
        tbMotClef.Size = new Size(355, 27);
        tbMotClef.TabIndex = 4;
        // 
        // bRechercher
        // 
        bRechercher.AutoSize = true;
        bRechercher.Location = new Point(364, 3);
        bRechercher.Name = "bRechercher";
        bRechercher.Size = new Size(109, 30);
        bRechercher.TabIndex = 5;
        bRechercher.Text = "&Rechercher";
        bRechercher.UseVisualStyleBackColor = true;
        bRechercher.Click += bRechercher_Click;
        // 
        // bTous
        // 
        bTous.Location = new Point(479, 3);
        bTous.Name = "bTous";
        bTous.Size = new Size(94, 29);
        bTous.TabIndex = 6;
        bTous.Text = "&Tous";
        bTous.UseVisualStyleBackColor = true;
        bTous.Click += bTous_Click;
        // 
        // dgvContacts
        // 
        dgvContacts.AllowUserToAddRows = false;
        dgvContacts.AllowUserToDeleteRows = false;
        dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvContacts.Columns.AddRange(new DataGridViewColumn[] { dgvContactsColumnNom, dgvContactsColumnCourriel });
        dgvContacts.Dock = DockStyle.Fill;
        dgvContacts.Location = new Point(3, 184);
        dgvContacts.Name = "dgvContacts";
        dgvContacts.ReadOnly = true;
        dgvContacts.RowHeadersVisible = false;
        dgvContacts.RowHeadersWidth = 51;
        dgvContacts.ScrollBars = ScrollBars.Vertical;
        dgvContacts.Size = new Size(776, 321);
        dgvContacts.AutoGenerateColumns = false;
        // 
        // dvgContactsColumnNom
        // 
        dgvContactsColumnNom.HeaderText = "Nom";
        dgvContactsColumnNom.MinimumWidth = 125;
        dgvContactsColumnNom.Name = "dvgContactsColumnNom";
        dgvContactsColumnNom.ReadOnly = true;
        dgvContactsColumnNom.DataPropertyName = "Nom";
        // 
        // dvgContactsColumnCourriel
        // 
        dgvContactsColumnCourriel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dgvContactsColumnCourriel.FillWeight = 70F;
        dgvContactsColumnCourriel.HeaderText = "Courriel";
        dgvContactsColumnCourriel.MinimumWidth = 6;
        dgvContactsColumnCourriel.Name = "dvgContactsColumnCourriel";
        dgvContactsColumnCourriel.ReadOnly = true;
        dgvContactsColumnCourriel.DataPropertyName = "Courriel";
        // 
        // lNombre
        // 
        lNombre.AutoSize = true;
        lNombre.Location = new Point(3, 508);
        lNombre.Name = "lNombre";
        lNombre.Text = "0 contacts(s) - INombre";
        // 
        // lEtat
        // 
        lEtat.AutoSize = true;
        lEtat.Name = "lEtat";
        lEtat.Text = "État de l'opération -- IEtat";
        lNombre.Padding = new Padding(0, 10, 0, 10);
        // 
        // FormContacts
        // 
        AcceptButton = bCreer;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 548);
        Controls.Add(tableLayoutRoot);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(797, 584);
        Name = "FormContacts";
        Text = "Fiche de contact — à construire";
        Load += FormContacts_Load;
        tableLayoutRoot.ResumeLayout(false);
        tableLayoutRoot.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanelMotClef.ResumeLayout(false);
        tableLayoutPanelMotClef.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
        ResumeLayout(false);
        // Construire les contrôles dans le designer et relier chaque Click une seule fois.
    }
    private TableLayoutPanel tableLayoutRoot;
    private Label lTitle;
    private TableLayoutPanel tableLayoutPanel1;
    private Label lNom;
    private Label lCourriel;
    private TextBox tbNom;
    private TextBox tbCourriel;
    private Button bCreer;
    private Label lEtat;
    private Button bEffacer;
    private Label lMotClef;
    private TableLayoutPanel tableLayoutPanelMotClef;
    private TextBox tbMotClef;
    private Button bRechercher;
    private Button bTous;
    private DataGridView dgvContacts;
    private DataGridViewTextBoxColumn dgvContactsColumnNom;
    private DataGridViewTextBoxColumn dgvContactsColumnCourriel;
    private Label lNombre;
}
