﻿using System.ComponentModel.DataAnnotations;

namespace SdA.AFrodoJourney.Core.Models
{
    /// <summary>
    ///  Value object
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    public record Vector2(int X, int Y);

    /// <summary>
    /// 
    /// </summary>
    public class Person
    {
        private readonly IMoving defaultMoving;

        #region Constructors
        public Person(IMoving defaultMoving)
        {
            this.defaultMoving = defaultMoving;
        }

        public Person() : this(null) { }
        #endregion

        #region Public methods
        public void Move(IMoving moving)
        {
            if (moving == null)
            {
                moving = this.defaultMoving;
            }

            var position = moving.Move(); // Je définis le quoi, pas le comment // le comment est externalisé dans une classe via le guide : l'interface
            this.CurrentPosition = new Vector2(position.X, position.Y);
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "C'est requis !")]
        [MinLength(10, ErrorMessage = "Il faut 10 caractères min")]
        public string Surname { get; set; } = string.Empty;

        [Range(0, 300)]
        public int? Height { get; set; }

        public Vector2 CurrentPosition { get; set; } = new Vector2(0, 0);
        #endregion
    }
}
