using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{

    public class person
    {
        private int age;
        EventBroker broker;
		private int bosker;
		
        public person(EventBroker broker )
        {
            this.broker = broker;
        }
    }

    public class EventBroker
    {
        //All Events that happened
        public IList<Event> AllEvents = new List<Event>();

        public event EventHandler<Command> Commands;
        public event EventHandler<Query> Queries;

        public void Command(Command c)
        {
            Commands?.Invoke(this, c);
        }

        private void BrokerOnCommands(object sender,Command command)
        {
            throw new NotImplementedException();
        }
    }

    public class Command
    {

    }

    public class Query
    {

    }

    public class Event
    {
        //backtrack
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ab = new EventBroker();
            var p = new person();
            Console.ReadKey();
        }
    }
}
