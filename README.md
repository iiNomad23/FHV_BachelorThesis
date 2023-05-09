# Bachelor's Thesis

This repository includes all LaTeX files of my bachelor's thesis **Integrating a feature-oriented testing system into the development cycle of technical systems**. 

Written with [Overleaf](https://www.overleaf.com/) and [TeXstudio](https://www.texstudio.org/).

### Abstract
The development of technical systems is a complex and costly process. 
Therefore, it is important that products are thoroughly tested before delivery to the customer. 
However, this is often neglected or done insufficiently due to time pressure and deadlines. 
A well-structured test plan can minimize this risk and integrate the testing process into the product development cycle. 
This allows stable hardware and efficient, well-structured software to be delivered to the customer without significant delays.  

Using techniques such as feature-oriented development, certain features must be accepted and tested before the product release. 
This in turn allows newly implemented features to be thoroughly tested and contribute to high quality.  

This can be achieved by structuring features in a database. 
A system based on these feature descriptions can support automatic testing, conduct targeted tests for individual features, and accelerate their acceptance. 
This reduces testing effort and provides focused feedback to the developers.


# Latex Setup Windows

- Tex Live
- TexStudio
- Code Listings:
  - minted
    - python -m pip install -U pygments
    - evtl. Python scripts zu PATH hinzufügen
    - Texstudio: options > configure > commands
      - PdfLatex -> pdflatex.exe -synctex=1 -interaction=nonstopmode --shell-escape %.tex
- Bib settings:
  - Texstudio: bibliography
    - Type -> BibLaTeX
  - Texstudio: options > configure > build
    - Default Bibliography Tool -> Biber

