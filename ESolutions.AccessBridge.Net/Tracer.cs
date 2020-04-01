using System;
using System.Collections.Generic;
using System.Text;

namespace ESolutions.AccessBridge.DotNet
{
	/// <summary>
	/// Class to trace messages and exceptions.
	/// </summary>
	public static class Tracer
	{
		//Methods
		#region TraceException
		/// <summary>
		/// Traces the exception.
		/// </summary>
		/// <param name="ex">The ex.</param>
		public static void TraceException(Exception ex)
		{
			var exceptionMessage = $"{ex.Message} - {ex.StackTrace}";
			Tracer.TraceMessage(exceptionMessage);

			ExceptionForm form = new ExceptionForm();
			form.ShowDialog(ex);
		}
		#endregion

		#region TraceMessage
		/// <summary>
		/// Traces the message.
		/// </summary>
		/// <param name="message">The message.</param>
		public static void TraceMessage(String message)
		{
			System.Diagnostics.Trace.WriteLine(
				DateTime.Now.ToString("u") +
				" - " +
				message);
		}
		#endregion
	}
}
