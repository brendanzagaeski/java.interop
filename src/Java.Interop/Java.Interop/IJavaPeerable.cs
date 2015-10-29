using System;

namespace Java.Interop
{
	public interface IJavaPeerable : IDisposable
	{
		JniObjectReference      PeerReference  {get;}
		JniPeerMembers          JniPeerMembers {get;}

		void    UnregisterFromRuntime ();
		void    DisposeUnlessRegistered ();
	}
}

