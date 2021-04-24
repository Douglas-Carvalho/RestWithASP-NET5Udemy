using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private List<Episode> episodes;

        public EpisodesController()
        {
            episodes = new List<Episode>() {
                new Episode()
                {
                    id = "a-importancia-da-contribuicao-em-open-source",
                    title = "Faladev #30 | A importância da contribuição em Open Source",
                    members = "Diego Fernandes, João Pedro, Diego Haz e Bruno Lemos",
                    published_at = "2021-01-22 16:35:40",
                    thumbnail = "https://storage.googleapis.com/golden-wind/nextlevelweek/05-podcastr/opensource.jpg",
                    description = "<p>Nesse episódio do Faladev, Diego Fernandes se reúne com João Pedro Schmitz, Bruno Lemos e Diego Haz, para discutir sobre a importância da contribuição open source e quais desafios circulam na comunidade.</p><p>A gente passa a maior parte do tempo escrevendo código. Agora chegou o momento de falar sobre isso. Toda semana reunimos profissionais da tecnologia para discutir sobre tudo que circula na órbita da programação.</p><p>O Faladev é um podcast original Rocketseat.</p>",
                    file = new File()
                    {
                        url = "https://storage.googleapis.com/golden-wind/nextlevelweek/05-podcastr/audios/opensource.m4a",
                        type = "audio/x-m4a",
                        duration = 3981
                    }
                }
            };
        }

        // Maps GET requests to https://localhost:{port}/api/book
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<Episode>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get()
        {
            return Ok(episodes);
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(string))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Get(string id)
        {
            return Ok(episodes.Where(e => e.id == id));
        }
    }
}
