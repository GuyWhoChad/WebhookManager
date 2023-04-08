using JNogueira.Discord.Webhook.Client;

using System;

namespace WebhookController

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new DiscordWebhookClient(textBox2.Text);

            var message = new DiscordMessage(
    "WebhookManager Connected Successfully and Sent this Message!" + DiscordEmoji.WhiteCheckMark,
    username: "WebhookManager Connection",

    tts: false,
    embeds: new[]
    {
        new DiscordMessageEmbed(

            color: 0,

            description: textBox1.Text


        )
    }
);

            // Send the message!
            client.SendToDiscord(message);
            MessageBox.Show("The DISCORD WEBHOOK has been successfully connected!", "Webhook Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}