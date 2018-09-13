using System;

namespace Calculator.CQRS.Events
{
	public class CalculatorAddEvent:Event
	{
		

		public CalculatorAddEvent(Guid aggregateId)
		{
			AggregateId = aggregateId;
			
		}
	}
}
