using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BankSystem.BLL
{
    public class TelegramService
    {
        private static readonly ITelegramBotClient botClient = new TelegramBotClient("8747659496:AAHhrAIBFMb-GM_8f3LHS8AiCPXcMpRCifc");

        public async Task<string?> GetLatestChatIdAsync()
        {
            try
            {
                var updates = await botClient.GetUpdates();
                var lastUpdate = updates.LastOrDefault();

                return lastUpdate?.Message?.Chat.Id.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Telegram Error: " + ex.Message);
                return null;
            }
        }

        public async Task SendOtpAsync(string chatId, string otpCode)
        {
            if (string.IsNullOrEmpty(chatId)) return;

            try
            {
                await botClient.SendMessage(
                    chatId: chatId,
                    text:"លេខកូដ OTP របស់អ្នក៖ " + otpCode
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Telegram Error: " + ex.Message);
            }
        }
    }
}