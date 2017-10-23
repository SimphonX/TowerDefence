using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
using System.Threading;

namespace Audio
{
    class EnemyUnitSoundAdapter : Sound
    {
        IWaveSource soundSource;
        ISoundOut soundOut;
        string audioFile;

        public EnemyUnitSoundAdapter(string audioFile)
        {
            System.Console.WriteLine(audioFile);
            this.audioFile = audioFile;
        }

        public void PlaySound()
        {
            using (soundSource = GetSoundSource())
            {
                using (soundOut = GetSoundOut())
                {
                    soundOut.Initialize(soundSource);
                    soundOut.Play();

                    Thread.Sleep(500);
                    
                    soundOut.Stop();
                }
            }
        }
        private ISoundOut GetSoundOut()
        {
            if (WasapiOut.IsSupportedOnCurrentPlatform)
                return new WasapiOut();
            else
                return new DirectSoundOut();
        }
        private IWaveSource GetSoundSource()
        {
            return CodecFactory.Instance.GetCodec(audioFile);
        }
    }
}
