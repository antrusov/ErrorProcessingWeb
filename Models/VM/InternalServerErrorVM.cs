namespace ErrorProcessingWeb.Models.VM;

public class InternalServerErrorVM
{
        /// <summary>
        /// Тип ошибки.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Момент заполнения структуры данных для исключительной ситуации.
        /// </summary>
        public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
}