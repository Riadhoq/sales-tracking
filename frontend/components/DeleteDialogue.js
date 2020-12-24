import {
  AlertDialog,
  AlertDialogBody,
  AlertDialogContent,
  AlertDialogFooter,
  AlertDialogHeader,
  AlertDialogOverlay,
  Button,
  useToast,
} from "@chakra-ui/react";
import { useRef, useState } from "react";
import { useRouter } from "next/router";

const DeleteDialogue = ({ deleteUrl }) => {
  const [isOpen, setIsOpen] = useState(false);
  const onClose = () => setIsOpen(false);
  const toast = useToast();
  const route = useRouter();
  const onDelete = async () => {
    var res = await fetch(deleteUrl, { method: "POST" });

    if (res.status === 200) {
      toast({
        title: "Delete Successful",
        description: "Record deleted successfully",
        status: "success",
        duration: 2000,
        isClosable: true,
      });
      setIsOpen(false);
      route.back();
    } else {
      toast({
        title: "Delete Unsuccessful",
        description: JSON.stringify(await res.json()),
        status: "error",
        duration: 2000,
        isClosable: true,
      });
      setIsOpen(false);
    }
  };
  const cancelRef = useRef();

  return (
    <>
      <Button colorScheme="red" onClick={() => setIsOpen(true)}>
        Delete
      </Button>

      <AlertDialog
        isOpen={isOpen}
        leastDestructiveRef={cancelRef}
        onClose={onClose}
      >
        <AlertDialogOverlay>
          <AlertDialogContent>
            <AlertDialogHeader fontSize="lg" fontWeight="bold">
              Delete
            </AlertDialogHeader>

            <AlertDialogBody>
              Are you sure? You can't undo this action afterwards.
            </AlertDialogBody>

            <AlertDialogFooter>
              <Button ref={cancelRef} onClick={onClose}>
                Cancel
              </Button>
              <Button colorScheme="red" onClick={onDelete} ml={3}>
                Delete
              </Button>
            </AlertDialogFooter>
          </AlertDialogContent>
        </AlertDialogOverlay>
      </AlertDialog>
    </>
  );
};

export default DeleteDialogue;
