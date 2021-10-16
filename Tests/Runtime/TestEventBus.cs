﻿namespace GenericEventBus.Tests
{
	public class TestEventBus : GenericEventBus<ITestEvent>
	{
		public TestListener<TEvent> TestListener<TEvent>() where TEvent : ITestEvent
		{
			return new TestListener<TEvent>(this);
		}

		public TestListener<TEvent> TestListen<TEvent>(float priority = 0,
			TestListener<TEvent>.EventReceivedHandler callback = null) where TEvent : ITestEvent
		{
			var listener = TestListener<TEvent>();
			listener.Subscribe(priority, callback);

			return listener;
		}
	}
}