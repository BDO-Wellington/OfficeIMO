﻿using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Packaging;

namespace OfficeIMO.Word {
    /// <summary>
    /// Provides strongly typed access to the extended application properties
    /// stored in the underlying <see cref="WordprocessingDocument"/>.
    /// </summary>
    public class ApplicationProperties {
        private readonly WordprocessingDocument _wordprocessingDocument = null;
        private readonly WordDocument _document = null;

        /// <summary>
        /// Gets or sets the application name that created the document.
        /// </summary>
        public string Application {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Application == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Application.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Application == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Application = new Application();
                }

                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Application.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the version of the application that created the document.
        /// </summary>
        public string ApplicationVersion {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ApplicationVersion == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ApplicationVersion.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ApplicationVersion == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ApplicationVersion = new ApplicationVersion();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ApplicationVersion.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the total number of paragraphs in the document.
        /// </summary>
        public string Paragraphs {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs = new Paragraphs();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the total number of pages in the document.
        /// </summary>
        public string Pages {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Pages == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Pages.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Pages == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Pages = new Pages();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Pages.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the character count of the document.
        /// </summary>
        public string Characters {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Characters == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Characters.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Paragraphs = new Paragraphs();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Characters.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the character count including spaces.
        /// </summary>
        public string CharactersWithSpaces {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.CharactersWithSpaces == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.CharactersWithSpaces.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.CharactersWithSpaces == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.CharactersWithSpaces = new CharactersWithSpaces();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.CharactersWithSpaces.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the company associated with the document.
        /// </summary>
        public string Company {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return "";
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Company == null) {
                    return "";
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Company.Text;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Company == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Company = new Company();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Company.Text = value;
            }
        }
        /// <summary>
        /// Gets or sets the digital signature information for the document.
        /// </summary>
        public DigitalSignature DigitalSignature {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DigitalSignature == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DigitalSignature;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DigitalSignature == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DigitalSignature = new DigitalSignature();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DigitalSignature = value;
            }
        }
        /// <summary>
        /// Gets or sets the document security information.
        /// </summary>
        public DocumentSecurity DocumentSecurity {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DocumentSecurity == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DocumentSecurity;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DocumentSecurity == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DocumentSecurity = new DocumentSecurity();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.DocumentSecurity = value;
            }
        }
        /// <summary>
        /// Gets or sets the heading pairs associated with the document.
        /// </summary>
        public HeadingPairs HeadingPairs {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HeadingPairs == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HeadingPairs;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HeadingPairs == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HeadingPairs = new HeadingPairs();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HeadingPairs = value;
            }
        }
        /// <summary>
        /// Gets or sets the hidden slides information for the document.
        /// </summary>
        public HiddenSlides HiddenSlides {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HiddenSlides == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HiddenSlides;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HiddenSlides == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HiddenSlides = new HiddenSlides();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HiddenSlides = value;
            }
        }
        /// <summary>
        /// Gets or sets the base address used for resolving hyperlinks.
        /// </summary>
        public HyperlinkBase HyperlinkBase {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkBase == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkBase;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkBase == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkBase = new HyperlinkBase();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkBase = value;
            }
        }
        /// <summary>
        /// Gets or sets the list of hyperlinks in the document.
        /// </summary>
        public HyperlinkList HyperlinkList {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkList == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkList;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkList == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkList = new HyperlinkList();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinkList = value;
            }
        }
        /// <summary>
        /// Gets or sets the total number of lines in the document.
        /// </summary>
        public Lines Lines {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Lines == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Lines;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Lines == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Lines = new Lines();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Lines = value;
            }
        }
        /// <summary>
        /// Gets or sets the manager associated with the document.
        /// </summary>
        public Manager Manager {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Manager == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Manager;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Manager == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Manager = new Manager();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Manager = value;
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether hyperlinks have changed.
        /// </summary>
        public HyperlinksChanged HyperlinksChanged {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinksChanged == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinksChanged;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinksChanged == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinksChanged = new HyperlinksChanged();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.HyperlinksChanged = value;
            }
        }
        /// <summary>
        /// Gets or sets the notes information for the document.
        /// </summary>
        public Notes Notes {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Notes == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Notes;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Notes == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Notes = new Notes();
                }

                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Notes = value;
            }
        }
        /// <summary>
        /// Gets or sets the multimedia clips associated with the document.
        /// </summary>
        public MultimediaClips MultimediaClips {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.MultimediaClips == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.MultimediaClips;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.MultimediaClips == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.MultimediaClips = new MultimediaClips();
                }

                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.MultimediaClips = value;
            }
        }
        /// <summary>
        /// Gets or sets the total editing time for the document.
        /// </summary>
        public TotalTime TotalTime {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.TotalTime == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.TotalTime;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.TotalTime == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.TotalTime = new TotalTime();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.TotalTime = value;
            }
        }
        /// <summary>
        /// Gets or sets the scale crop information for the document.
        /// </summary>
        public ScaleCrop ScaleCrop {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ScaleCrop == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ScaleCrop;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ScaleCrop == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ScaleCrop = new ScaleCrop();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.ScaleCrop = value;
            }
        }
        /// <summary>
        /// Gets or sets the presentation format used by the document.
        /// </summary>
        public PresentationFormat PresentationFormat {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.PresentationFormat;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.PresentationFormat == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.PresentationFormat = new PresentationFormat();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.PresentationFormat = value;
            }
        }
        /// <summary>
        /// Gets or sets the template from which the document was created.
        /// </summary>
        public Template Template {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Template;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Template == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Template = new Template();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Template = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the document is shared.
        /// </summary>
        public SharedDocument SharedDocument {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.SharedDocument;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.SharedDocument == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.SharedDocument = new SharedDocument();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.SharedDocument = value;
            }
        }

        /// <summary>
        /// Gets or sets the total number of words in the document.
        /// </summary>
        public Words Words {
            get {
                if (_wordprocessingDocument.ExtendedFilePropertiesPart == null || _wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                    return null;
                }
                return _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Words;
            }
            set {
                CreateExtendedFileProperties();
                if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Words == null) {
                    _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Words = new Words();
                }
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties.Words = value;
            }
        }

        /// <summary>
        /// Initializes a new instance bound to the specified document.
        /// </summary>
        /// <param name="document">Parent document.</param>
        public ApplicationProperties(WordDocument document) {
            _document = document;
            _wordprocessingDocument = document._wordprocessingDocument;
            _document.ApplicationProperties = this;
        }

        private void CreateExtendedFileProperties() {
            if (_wordprocessingDocument.ExtendedFilePropertiesPart == null) {
                _wordprocessingDocument.AddExtendedFilePropertiesPart();
            }

            if (_wordprocessingDocument.ExtendedFilePropertiesPart.Properties == null) {
                _wordprocessingDocument.ExtendedFilePropertiesPart.Properties = new Properties();
            }
        }
    }
}
