import { data } from "../data";
import ButtonNext from "./ButtonNext";
import Header from "./Header";
import Image from "./Image";
import ShowDetail from "./ShowDetail";
import { useState } from "react";
function Gallery() {
    const [index, setIndex] = useState(0)

    function handleClicIndex() {
        setIndex(index + 1)
    }

    let galleryData = data[index]
    return (
        <div>
            <ButtonNext click={handleClicIndex}/>
            <Header title={galleryData.name} sizeList={data.length} index={index + 1} />
            <ShowDetail description={galleryData.description} />
            <Image urlImg={galleryData.url} alt={galleryData.alt} />
        </div>
    );
}

export default Gallery;