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
        public void PlaySound()
        {
            using (soundSource = GetSoundSource())
            {
                //SoundOut implementation which plays the sound
                using (soundOut = GetSoundOut())
                {
                    //Tell the SoundOut which sound it has to play
                    soundOut.Initialize(soundSource);
                    //Play the sound
                    soundOut.Play();

                    Thread.Sleep(2000);

                    //Stop the playback
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
            //return any source ... in this example, we'll just play a mp3 file
            return CodecFactory.Instance.GetCodec(@"C:\Temp\sound.mp3");
        }
    }
}
