using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnifyAPI.Service
{
    public interface ISpotifyService
    {
        Task SetAuthorization(string code);
        Task GetTracks(int x);
        Task GetAudioFeatures(List<string> Ids);
        void Comparator(List<string> Stef, List<string> Chris);
        void DecisionTree();

    }
}
