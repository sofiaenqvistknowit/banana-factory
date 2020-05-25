export class Image {
    public ImageId: number;
    public Image: File;
    

    constructor(private image: Image) {
        this.createModel(image);
    }

    createModel(image: Image) {
        this.ImageId = image.ImageId;
        this.Image = image.Image;
    }

}