using System;

namespace Generics
{
    internal class Quiz<T>
    {
        // ITask interface definition
        public interface ITask<T>
        {
            T Perform();
        }

        // EmailTask class implements ITask<string>
        class EmailTask : ITask<string>
        {
            public string Recipient { get; set; }
            public string Message { get; set; }

            // Constructor to initialize properties
            public EmailTask(string message, string recipient)
            {
                Message = message;
                Recipient = recipient;
            }

            // Perform method returns a string (simulating sending an email)
            public string Perform()
            {
                return $"Email sent to {Recipient} with message: {Message}";
            }
        }

        // ReportClass implements ITask<string>
        class ReportClass : ITask<string>
        {
            public string ReportName { get; set; }

            // Constructor to initialize ReportName
            public ReportClass(string reportName)
            {
                ReportName = reportName;
            }

            // Perform method generates a report
            public string Perform()
            {
                return $"{ReportName} generated successfully";
            }
        }

        // TaskProcessor class that processes tasks of type TTask
        class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
        {
            public TTask Task { get; set; }

            // Constructor to initialize the task
            public TaskProcessor(TTask task)
            {
                Task = task;
            }

            // Perform method returns the result of task's Perform method
            public TResult Perform()
            {
                return Task.Perform();
            }
        }

    
    }
}
