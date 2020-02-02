﻿using I2PCore.Data;
using Org.BouncyCastle.Crypto.Modes;

namespace I2PCore.Transport.NTCP
{
    public class NTCPRunningContext
    {
        public I2PKeysAndCert RemoteRouterIdentity;
        public I2PSessionKey SessionKey;

        public CbcBlockCipher Encryptor;
        public CbcBlockCipher Dectryptor;

        public int TransportInstance;
    }
}
