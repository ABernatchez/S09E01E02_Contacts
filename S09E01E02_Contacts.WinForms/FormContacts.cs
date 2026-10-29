using System.Text.Json;
using Contacts.Application;

namespace Contacts.WinForms;

public partial class FormContacts : Form
{
    private readonly CreerContact? m_creation;
    private readonly ConsulterContacts? m_consultation;
    private readonly IJournalIncidents? m_journal;

    public FormContacts()
    {
        InitializeComponent();
    }

    public FormContacts(CreerContact creation, ConsulterContacts consultation, IJournalIncidents journal) : this()
    {
        ArgumentNullException.ThrowIfNull(creation);
        ArgumentNullException.ThrowIfNull(consultation);
        ArgumentNullException.ThrowIfNull(journal);
        m_creation = creation;
        m_consultation = consultation;
        m_journal = journal;
    }

    private CreerContact Creation
    {
        get
        {
            if (m_creation == null)
            {
                throw new InvalidOperationException("Le lancement doit injecter le cas d'utilisation.");
            }

            return m_creation;
        }
    }

    private ConsulterContacts Consultation
    {
        get
        {
            if (m_consultation == null)
            {
                throw new InvalidOperationException("Le lancement doit injecter la consultation.");
            }

            return m_consultation;
        }
    }

    private void FormContacts_Load(object? sender, EventArgs e)
    {
        try
        {
            IReadOnlyCollection<ContactDto> contacts = Consultation.ObtenirTous();
            AfficherContacts(contacts);
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("Obtenir tous les contacts", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("Obtenir tous les contacts", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("Obtenir tous les contacts", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("Obtenir tous les contacts", exception);
        }
        
    }

    private void bCreer_Click(object? sender, EventArgs e)
    {
        try
        {
            DemandeCreationContact demandeCreation = new(tbNom.Text, tbCourriel.Text);
            Result<ContactDto> result = Creation.Executer(demandeCreation);
            if (result.EstSucces)
            {
                AfficherMessage($"Nom contact créer: {result.Valeur.Nom}");
                IReadOnlyCollection<ContactDto> contacts = Consultation.ObtenirTous();
                AfficherContacts(contacts);

                tbNom.Clear();
                tbCourriel.Clear();
                tbMotClef.Clear();

                tbNom.Focus();
            }
            else
            {
                AfficherMessage(result.MessageErreur);
            }
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("créer contact", exception);
        }
    }

    private void bEffacer_Click(object? sender, EventArgs e)
    {
        EffacerSaisie();
        AfficherMessage(string.Empty);
    }

    private void EffacerSaisie()
    {
        tbNom.Clear();
        tbCourriel.Clear();
        tbNom.Focus();
    }

    private void AfficherMessage(string message)
    {
        lEtat.Text = $"État de l'opération -- {message}";
    }

    private void bRechercher_Click(object? sender, EventArgs e)
    {
        try
        {
            IReadOnlyCollection<ContactDto> contacts = Consultation.Rechercher(tbMotClef.Text);
            AfficherContacts(contacts);
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
    }

    private void bTous_Click(object? sender, EventArgs e)
    {
        try
        {
            tbMotClef.Clear();
            IReadOnlyCollection<ContactDto> contacts = Consultation.ObtenirTous();
            AfficherContacts(contacts);
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
    }

    private void AfficherContacts(IReadOnlyCollection<ContactDto> contacts)
    {
        dgvContacts.DataSource = contacts;
        lNombre.Text = $"{contacts.Count} contacts(s)";
    }

    private void SignalerIncident(string operation, Exception exception)
    {
        m_journal?.Consigner(operation, exception);
        AfficherMessage("Opération impossible pour le moment. Réessayez après correction de l'incident.");
    }
}
