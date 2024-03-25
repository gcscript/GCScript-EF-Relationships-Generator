using System.Text;

namespace GCScript_EF_Relationships_Generator;

public partial class frm_Main : Form
{
    public frm_Main()
    {
        InitializeComponent();
        cmb_Relationship.Items.Add("One to One (1:1)");
        cmb_Relationship.Items.Add("One to Many (1:N)");
        cmb_Relationship.SelectedIndex = 0;
        cmb_IdType.Items.Add("int");
        cmb_IdType.Items.Add("Guid");
        cmb_IdType.SelectedIndex = 1;

        cmb_EntityArticle1.Items.Add("um");
        cmb_EntityArticle1.Items.Add("uma");
        cmb_EntityArticle1.SelectedIndex = 0;
        cmb_EntityArticle2.Items.Add("um");
        cmb_EntityArticle2.Items.Add("uma");
        cmb_EntityArticle2.SelectedIndex = 0;
        cmb_EntityVerb1.Items.Add("ter");
        cmb_EntityVerb1.Items.Add("estar em");
        cmb_EntityVerb1.SelectedIndex = 0;
        cmb_EntityVerb2.Items.Add("ter");
        cmb_EntityVerb2.Items.Add("estar em");
        cmb_EntityVerb2.SelectedIndex = 1;
        cmb_EntityPronouns2.Items.Add("muitos");
        cmb_EntityPronouns2.Items.Add("muitas");
        cmb_EntityPronouns2.SelectedIndex = 0;
        chk_Comments.Checked = true;
        chk_Nullable.Checked = true;
        chk_IsRequired.Checked = true;
        chk_AutoArticleAndVerb.Checked = true;
    }

    private void txt_Entity1_TextChanged(object sender, EventArgs e) => Start();
    private void txt_Entity2_TextChanged(object sender, EventArgs e) => Start();
    private void cmb_Relationship_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void cmb_IdType_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void chk_IsRequired_CheckedChanged(object sender, EventArgs e) => Start();
    private void chk_Comments_CheckedChanged(object sender, EventArgs e) => Start();
    private void chk_Nullable_CheckedChanged(object sender, EventArgs e) => Start();
    private void cmb_EntityArticle1_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void cmb_EntityArticle2_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void cmb_EntityVerb1_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void cmb_EntityVerb2_SelectedIndexChanged(object sender, EventArgs e) => Start();
    private void cmb_EntityPronouns2_SelectedIndexChanged(object sender, EventArgs e) => Start();

    private void btn_CopyModel1_Click(object sender, EventArgs e) { try { Clipboard.SetText(rtxt_Model1.Text.Trim()); } catch { } }
    private void btn_CopyModel2_Click(object sender, EventArgs e) { try { Clipboard.SetText(rtxt_Model2.Text.Trim()); } catch { } }
    private void btn_CopyFluentApi_Click(object sender, EventArgs e) { try { Clipboard.SetText(rtxt_FluentApi.Text.Trim()); } catch { } }
    private void btn_CopyContext_Click(object sender, EventArgs e) { try { Clipboard.SetText(rtxt_Context.Text.Trim()); } catch { } }

    private void chk_AutoArticleAndVerb_CheckedChanged(object sender, EventArgs e)
    {
        cmb_EntityArticle1.Enabled = !chk_AutoArticleAndVerb.Checked;
        cmb_EntityArticle2.Enabled = !chk_AutoArticleAndVerb.Checked;
        cmb_EntityVerb1.Enabled = !chk_AutoArticleAndVerb.Checked;
        cmb_EntityVerb2.Enabled = !chk_AutoArticleAndVerb.Checked;
        cmb_EntityPronouns2.Enabled = !chk_AutoArticleAndVerb.Checked;
        Start();
    }

    private void Start()
    {
        string entity1 = txt_Entity1.Text;
        string entity2 = txt_Entity2.Text;
        string idType = cmb_IdType.Text;
        string isRequired = chk_IsRequired.Checked ? ".IsRequired()" : string.Empty;

        if (string.IsNullOrWhiteSpace(entity1) || string.IsNullOrWhiteSpace(entity2))
        {
            rtxt_Model1.Clear();
            rtxt_Model2.Clear();
            rtxt_FluentApi.Clear();
            rtxt_Context.Clear();
            lbl_Explanation.Text = string.Empty;
            return;
        }

        if (chk_AutoArticleAndVerb.Checked)
        {
            if (entity1.EndsWith("a") || entity1.EndsWith("as"))
            {
                cmb_EntityArticle1.SelectedIndex = 1;
                cmb_EntityVerb1.SelectedIndex = 0;
            }
            else if (entity1.EndsWith("o") || entity1.EndsWith("os"))
            {
                cmb_EntityArticle1.SelectedIndex = 0;
                cmb_EntityVerb1.SelectedIndex = 0;
            }
            if (entity2.EndsWith("a") || entity2.EndsWith("as"))
            {
                cmb_EntityArticle2.SelectedIndex = 1;
                cmb_EntityVerb2.SelectedIndex = 1;
                cmb_EntityPronouns2.SelectedIndex = 1;
            }
            else if (entity2.EndsWith("o") || entity2.EndsWith("os"))
            {
                cmb_EntityArticle2.SelectedIndex = 0;
                cmb_EntityVerb2.SelectedIndex = 1;
                cmb_EntityPronouns2.SelectedIndex = 0;
            }
        }
        else
        {
            cmb_EntityArticle1.SelectedIndex = 0;
            cmb_EntityArticle2.SelectedIndex = 0;
            cmb_EntityVerb1.SelectedIndex = 0;
            cmb_EntityVerb2.SelectedIndex = 1;
            cmb_EntityPronouns2.SelectedIndex = 0;
        }

        string article1 = cmb_EntityArticle1.Text;
        string article2 = cmb_EntityArticle2.Text;
        string verb1 = cmb_EntityVerb1.Text;
        string verb2 = cmb_EntityVerb2.Text;
        string pronouns2 = cmb_EntityPronouns2.Text;

        StringBuilder model1StringBuilder = new();
        StringBuilder model2StringBuilder = new();
        StringBuilder fluentApiStringBuilder = new();
        StringBuilder contextStringBuilder = new();
        switch (cmb_Relationship.Text)
        {
            case "One to One (1:1)":
                #region Model 1
                model1StringBuilder.AppendLine($"public class {entity1}");
                model1StringBuilder.AppendLine("{");
                model1StringBuilder.AppendLine($"\tpublic {idType} {entity1}Id {{ get; set; }}{(chk_Comments.Checked ? " // Primary Key" : string.Empty)}");
                model1StringBuilder.AppendLine($"\t// Other properties here!");
                model1StringBuilder.AppendLine();
                model1StringBuilder.AppendLine($"\tpublic {entity2}{(chk_Nullable.Checked ? "?" : string.Empty)} {entity2} {{ get; set; }}{(chk_Comments.Checked ? " // Navigation Property" : string.Empty)}");
                model1StringBuilder.AppendLine("}");
                rtxt_Model1.Text = model1StringBuilder.ToString().Trim();
                #endregion

                #region Model 2
                model2StringBuilder.AppendLine($"public class {entity2}");
                model2StringBuilder.AppendLine("{");
                model2StringBuilder.AppendLine($"\tpublic {idType} {entity2}Id {{ get; set; }}{(chk_Comments.Checked ? " // Primary Key" : string.Empty)}");
                model2StringBuilder.AppendLine($"\t// Other properties here!");
                model2StringBuilder.AppendLine();
                model2StringBuilder.AppendLine($"\tpublic {idType} {entity1}Id {{ get; set; }}{(chk_Comments.Checked ? " // Foreign Key" : string.Empty)}");
                model2StringBuilder.AppendLine($"\tpublic {entity1}{(chk_Nullable.Checked ? "?" : string.Empty)} {entity1} {{ get; set; }}{(chk_Comments.Checked ? " // Navigation Property" : string.Empty)}");
                model2StringBuilder.AppendLine("}");
                rtxt_Model2.Text = model2StringBuilder.ToString().Trim();
                #endregion

                #region Fluent API
                fluentApiStringBuilder.AppendLine($"public class {entity1}Map : IEntityTypeConfiguration<{entity1}>");
                fluentApiStringBuilder.AppendLine("{");
                fluentApiStringBuilder.AppendLine($"\tbuilder.HasOne<{entity2}>(x => x.{entity2})\n\t\t.WithOne(x => x.{entity1})\n\t\t.HasForeignKey<{entity2}>(x => x.{entity1}Id)\n\t\t.HasConstraintName(\"FK_{entity1}_{entity2}\"){isRequired};");
                fluentApiStringBuilder.AppendLine("}");
                rtxt_FluentApi.Text = fluentApiStringBuilder.ToString().Trim();
                #endregion

                lbl_Explanation.Text = $"Se você está querendo que {article1} {entity1} possa {verb1} apenas {article2} {entity2}, e {article2} {entity2} possa {verb2} apenas {article1} {entity1}!";
                break;
            case "One to Many (1:N)":

                #region Model 1
                model1StringBuilder.AppendLine($"public class {entity1}");
                model1StringBuilder.AppendLine("{");
                model1StringBuilder.AppendLine($"\tpublic {idType} {entity1}Id {{ get; set; }}{(chk_Comments.Checked ? " // Primary Key" : string.Empty)}");
                model1StringBuilder.AppendLine($"\t// Other properties here!");
                model1StringBuilder.AppendLine();
                model1StringBuilder.AppendLine($"\tpublic ICollection<{entity2}>{(chk_Nullable.Checked ? "?" : string.Empty)} {entity2}s {{ get; set; }}{(chk_Comments.Checked ? " // Navigation Property" : string.Empty)}");
                model1StringBuilder.AppendLine("}");
                rtxt_Model1.Text = model1StringBuilder.ToString().Trim();
                #endregion

                #region Model 2
                model2StringBuilder.AppendLine($"public class {entity2}");
                model2StringBuilder.AppendLine("{");
                model2StringBuilder.AppendLine($"\tpublic {idType} {entity2}Id {{ get; set; }}{(chk_Comments.Checked ? " // Primary Key" : string.Empty)}");
                model2StringBuilder.AppendLine($"\t// Other properties here!");
                model2StringBuilder.AppendLine();
                model2StringBuilder.AppendLine($"\tpublic {idType} {entity1}Id {{ get; set; }}{(chk_Comments.Checked ? " // Foreign Key" : string.Empty)}");
                model2StringBuilder.AppendLine($"\tpublic {entity1}{(chk_Nullable.Checked ? "?" : string.Empty)} {entity1} {{ get; set; }}{(chk_Comments.Checked ? " // Navigation Property" : string.Empty)}");
                model2StringBuilder.AppendLine("}");
                rtxt_Model2.Text = model2StringBuilder.ToString().Trim();
                #endregion

                #region Fluent API
                fluentApiStringBuilder.AppendLine($"public class {entity1}Map : IEntityTypeConfiguration<{entity1}>");
                fluentApiStringBuilder.AppendLine("{");
                fluentApiStringBuilder.AppendLine($"\tbuilder.HasMany<{entity2}>(x => x.{entity2}s)\n\t\t.WithOne(x => x.{entity1})\n\t\t.HasForeignKey(x => x.{entity1}Id)\n\t\t.HasConstraintName(\"FK_{entity1}_{entity2}\"){isRequired};");
                fluentApiStringBuilder.AppendLine("}");
                rtxt_FluentApi.Text = fluentApiStringBuilder.ToString().Trim();
                #endregion

                lbl_Explanation.Text = $"Se você está querendo que {article1} {entity1} possa {verb1} {pronouns2} {entity2}s, mas {article2} {entity2} possa {verb2} apenas {article1} {entity1}!";
                break;
            default:
                break;
        }
        #region Context
        contextStringBuilder.AppendLine($"public class AppDbContext : DbContext");
        contextStringBuilder.AppendLine("{");
        contextStringBuilder.AppendLine($"\tpublic AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {{ }}");
        contextStringBuilder.AppendLine($"\tpublic DbSet<{entity1}> {entity1}s {{ get; set; }}");
        contextStringBuilder.AppendLine($"\tpublic DbSet<{entity2}> {entity2}s {{ get; set; }}");
        contextStringBuilder.AppendLine($"\t// Other DbSets here!");
        contextStringBuilder.AppendLine("}");
        rtxt_Context.Text = contextStringBuilder.ToString().Trim();
        #endregion
    }

    private void btn_ReverseRelationship_Click(object sender, EventArgs e)
    {
        string entity1 = txt_Entity1.Text;
        string entity2 = txt_Entity2.Text;
        int article1Index = cmb_EntityArticle1.SelectedIndex;
        int article2Index = cmb_EntityArticle2.SelectedIndex;
        int verb1Index = cmb_EntityVerb1.SelectedIndex;
        int verb2Index = cmb_EntityVerb2.SelectedIndex;

        txt_Entity1.Text = entity2;
        txt_Entity2.Text = entity1;
        cmb_EntityArticle1.SelectedIndex = article2Index;
        cmb_EntityArticle2.SelectedIndex = article1Index;
        cmb_EntityVerb1.SelectedIndex = verb2Index;
        cmb_EntityVerb2.SelectedIndex = verb1Index;
    }

    private void frm_Main_Load(object sender, EventArgs e)
    {
        txt_Entity1.Select();
    }

}
