using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.NetworkInformation;

namespace Tab3r.Utils.Network
{
    public static class NetworkUtils
    {
        /// <summary>
        /// Make a simple ping to host
        /// </summary>
        /// <param name="host">
        /// <para>host.</para>
        /// <para>Could be a hostname or ip address</para>
        /// </param>
        /// <returns>If ping was done correctly</returns>
        public static bool SimplePing(string host)
        {
            bool ok = true;
            Ping pingSender = new Ping();
            try
            {
                PingReply reply = pingSender.Send(host);
                if (reply.Status == IPStatus.Success)
                {

#if DEBUG
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
#endif
                    ok = true;
                }
                else
                {
                    Console.WriteLine(reply.Status);
                    ok = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                ok = false;
            }
            return ok;
        }


    }
}
